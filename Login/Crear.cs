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
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '•';
            txtRepetir.PasswordChar = '•';
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtRepetir.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return; // Salir del método si no están completos todos los campos
            }

            // Verificar que el campo de correo electrónico contenga el carácter '@'
            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El campo de correo electrónico debe contener el símbolo '@'.");
                return; // Salir del método si el correo electrónico no es válido
            }

            // Verificar que las contraseñas coincidan
            if (txtContraseña.Text != txtRepetir.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                return; // Salir del método si las contraseñas no coinciden
            }

            // Si todos los campos están completos y las contraseñas coinciden, proceder con la inserción en la base de datos
            string connectionString = "server=(localdb)\\senati; database=Proyecto; integrated security=true ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryRegistro = "INSERT INTO Registro (Nombre, Apellido, Correo, Usuario, Contraseña) VALUES (@Nombre, @Apellido, @Correo, @Usuario, @Contraseña)";
                using (SqlCommand commandRegistro = new SqlCommand(queryRegistro, connection))
                {
                    commandRegistro.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    commandRegistro.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    commandRegistro.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    commandRegistro.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    commandRegistro.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                    commandRegistro.ExecuteNonQuery();
                }

                string queryLogin = "INSERT INTO login (Usuario, Contraseña) VALUES (@Usuario, @Contraseña)";
                using (SqlCommand commandLogin = new SqlCommand(queryLogin, connection))
                {
                    commandLogin.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    commandLogin.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                    commandLogin.ExecuteNonQuery();
                }
            }

            // Notificar al usuario que los datos se han guardado correctamente
            MessageBox.Show("Los datos se han guardado correctamente.");

            // Mostrar Form1 y ocultar Form3
            this.Close();

        }

        private void btnMostrar2_CheckedChanged(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña entre '*' y '\0' (carácter nulo) para mostrar u ocultar
            if (btnMostrar2.Checked)
            {
                txtContraseña.PasswordChar = '\0'; // Mostrar contraseña
            }
            else
            {
                txtContraseña.PasswordChar = '*'; // Ocultar contraseña
            }
        }

        private void btnMostrar_CheckedChanged(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña entre '*' y '\0' (carácter nulo) para mostrar u ocultar
            if (btnMostrar.Checked)
            {
                txtRepetir.PasswordChar = '\0'; // Mostrar contraseña
            }
            else
            {
                txtRepetir.PasswordChar = '*'; // Ocultar contraseña
            }
        }
    }
}
