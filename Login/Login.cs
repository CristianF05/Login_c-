using System.Configuration;
using System.Data.SqlClient;
namespace Login
{

    public partial class Login : Form
    {

        // Usuario y contraseña almacenados
        public Login()
        {
            InitializeComponent();
            btnContraseña.PasswordChar = '•';
        }

        // Método para verificar las credenciales en la base de datos
        private bool VerificarCredenciales(string usuario, string contraseña)
        {
            string connectionString = "server=(localdb)\\senati; database=Proyecto; integrated security=true "; // Reemplaza esto con tu cadena de conexión real
            string query = "SELECT COUNT(*) FROM login WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = btnUsuario.Text;
            string contraseña = btnContraseña.Text;

            if (VerificarCredenciales(usuario, contraseña))
            {
                // Ocultar el formulario de inicio de sesión actual (Form1)
                this.Hide();

                // Abrir el formulario principal (Form2.cs)
                Pagina_inicial form2 = new Pagina_inicial();
                form2.FormClosed += (s, args) => this.Close(); // Cerrar Form1 cuando Form2 se cierre
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }

        private void btnUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkCrear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abrir Form3
            Crear form3 = new Crear();
            form3.FormClosed += (s, args) => this.Show(); // Mostrar Form1 cuando se cierre Form3
            form3.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mostrar Form4
            Recuperar form4 = new Recuperar();
            form4.FormClosed += (s, args) => this.Show(); // Mostrar Form1 cuando se cierre Form4
            form4.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void btnMostrar_CheckedChanged(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña entre '*' y '\0' (carácter nulo) para mostrar u ocultar
            if (btnMostrar.Checked)
            {
                btnContraseña.PasswordChar = '\0'; // Mostrar contraseña
            }
            else
            {
                btnContraseña.PasswordChar = '*'; // Ocultar contraseña
            }
        }
    }
}
