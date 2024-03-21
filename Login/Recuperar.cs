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
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return; // Salir del método si no están completos todos los campos
            }

            // Realizar la conexión a la base de datos y la consulta
            string connectionString = "Server=(localdb)\\senati;Database=Proyecto;Integrated Security=true;";
            string query = "SELECT COUNT(*) FROM Registro WHERE Nombre = @Nombre AND Usuario = @Usuario AND Correo = @Correo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar los valores de los parámetros
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    command.Parameters.AddWithValue("@Correo", txtCorreo.Text);

                    // Ejecutar la consulta y obtener el resultado
                    int count = (int)command.ExecuteScalar();

                    // Verificar si se encontraron coincidencias
                    if (count > 0)
                    {
                        // Si la verificación es exitosa, mostrar Form5 y cerrar Form4
                        Cambiar form5 = new Cambiar();
                        form5.FormClosed += (s, args) => this.Show(); // Mostrar Form1 cuando se cierre Form4
                        form5.Show();

                        // Ocultar Form1
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados no coinciden con nuestros registros.");
                    }
                }
            }
        }
    }
}
