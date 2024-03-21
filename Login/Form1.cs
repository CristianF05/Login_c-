using System.Configuration;
using System.Data.SqlClient;
namespace Login
{

    public partial class Form1 : Form
    {

        // Usuario y contrase�a almacenados
        public Form1()
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
                Form2 form2 = new Form2();
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
    }
}
