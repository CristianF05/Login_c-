namespace Login
{
    public partial class Form1 : Form
    {
        // Usuario y contraseña almacenados
        public Form1()
        {
            InitializeComponent();
            btnContraseña.PasswordChar = '•';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "tu_cadena_de_conexión"; // Reemplaza esto con tu cadena de conexión real

            // Crear la consulta SQL para verificar las credenciales
            string query = "SELECT COUNT(*) FROM login WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

            // Crear y abrir la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crear y configurar el comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar los valores de los parámetros
                    command.Parameters.AddWithValue("@Usuario", btnUsuario.Text);
                    command.Parameters.AddWithValue("@Contraseña", btnContraseña.Text);

                    // Ejecutar la consulta y obtener el resultado
                    int count = (int)command.ExecuteScalar();

                    // Verificar si se encontraron coincidencias
                    if (count > 0)
                    {
                        MessageBox.Show("¡Inicio de sesión exitoso!");

                        // Ocultar el formulario de inicio de sesión actual (Form1)
                        this.Hide();

                        // Abrir el formulario principal (Form2.cs)
                        Form2 form2 = new Form2();
                        form2.FormClosed += (s, args) => this.Close(); // Cerrar Form1 cuando Form2 se cierre
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                    }
                }
            }
        }

        private void btnUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
