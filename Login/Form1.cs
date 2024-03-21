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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "tu_cadena_de_conexi�n"; // Reemplaza esto con tu cadena de conexi�n real

            // Crear la consulta SQL para verificar las credenciales
            string query = "SELECT COUNT(*) FROM login WHERE Usuario = @Usuario AND Contrase�a = @Contrase�a";

            // Crear y abrir la conexi�n
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crear y configurar el comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar los valores de los par�metros
                    command.Parameters.AddWithValue("@Usuario", btnUsuario.Text);
                    command.Parameters.AddWithValue("@Contrase�a", btnContrase�a.Text);

                    // Ejecutar la consulta y obtener el resultado
                    int count = (int)command.ExecuteScalar();

                    // Verificar si se encontraron coincidencias
                    if (count > 0)
                    {
                        MessageBox.Show("�Inicio de sesi�n exitoso!");

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
