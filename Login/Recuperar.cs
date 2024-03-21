using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Recuperar : Form
    {
        public Recuperar()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtRepetir.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return; // Salir del método si no están completos todos los campos
            }

            // Verificar que las contraseñas coincidan
            if (txtContraseña.Text != txtRepetir.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                return; // Salir del método si las contraseñas no coinciden
            }

            // Realizar la conexión a la base de datos
            string connectionString = "Server=(localdb)\\senati;Database=Proyecto;Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Actualizar la contraseña en la tabla Registro
                string updateQueryRegistro = "UPDATE Registro SET Contraseña = @Contraseña WHERE Nombre = @Nombre AND Usuario = @Usuario AND Correo = @Correo";

                using (SqlCommand commandUpdateRegistro = new SqlCommand(updateQueryRegistro, connection))
                {
                    commandUpdateRegistro.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    commandUpdateRegistro.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    commandUpdateRegistro.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    commandUpdateRegistro.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                    int rowsAffectedRegistro = commandUpdateRegistro.ExecuteNonQuery();

                    if (rowsAffectedRegistro == 0)
                    {
                        MessageBox.Show("No se encontraron registros para actualizar.");
                        return;
                    }
                }

                // Actualizar la contraseña en la tabla login
                string updateQueryLogin = "UPDATE login SET Contraseña = @Contraseña WHERE Usuario = @Usuario";

                using (SqlCommand commandUpdateLogin = new SqlCommand(updateQueryLogin, connection))
                {
                    commandUpdateLogin.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    commandUpdateLogin.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                    int rowsAffectedLogin = commandUpdateLogin.ExecuteNonQuery();

                    if (rowsAffectedLogin == 0)
                    {
                        MessageBox.Show("No se encontraron registros para actualizar en la tabla login.");
                        return;
                    }
                }
            }
            this.Close();

        }
    }
}
