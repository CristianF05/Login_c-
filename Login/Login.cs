using System.Configuration;
using System.Data.SqlClient;
namespace Login
{

    public partial class Login : Form
    {

        // Usuario y contrase�a almacenados
        public Login()
        {
            InitializeComponent();
            btnContrase�a.PasswordChar = '�';
        }

        // M�todo para verificar las credenciales en la base de datos
        private bool VerificarCredenciales(string usuario, string contrase�a)
        {
            string connectionString = "server=(localdb)\\senati; database=Proyecto; integrated security=true "; // Reemplaza esto con tu cadena de conexi�n real
            string query = "SELECT COUNT(*) FROM login WHERE Usuario = @Usuario AND Contrase�a = @Contrase�a";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrase�a", contrase�a);

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
            string contrase�a = btnContrase�a.Text;

            if (VerificarCredenciales(usuario, contrase�a))
            {
                // Ocultar el formulario de inicio de sesi�n actual (Form1)
                this.Hide();

                // Abrir el formulario principal (Form2.cs)
                Pagina_inicial form2 = new Pagina_inicial();
                form2.FormClosed += (s, args) => this.Close(); // Cerrar Form1 cuando Form2 se cierre
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos. Por favor, int�ntelo de nuevo.");
            }
        }

        private void btnUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContrase�a_TextChanged(object sender, EventArgs e)
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
            // Cambiar el car�cter de contrase�a entre '*' y '\0' (car�cter nulo) para mostrar u ocultar
            if (btnMostrar.Checked)
            {
                btnContrase�a.PasswordChar = '\0'; // Mostrar contrase�a
            }
            else
            {
                btnContrase�a.PasswordChar = '*'; // Ocultar contrase�a
            }
        }
    }
}
