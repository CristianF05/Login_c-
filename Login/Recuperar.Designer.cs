namespace Login
{
    partial class Recuperar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCorreo = new TextBox();
            txtUsuario = new TextBox();
            btnEnviar = new Button();
            label5 = new Label();
            label6 = new Label();
            txtRepetir = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(355, 36);
            label1.TabIndex = 0;
            label1.Text = "Recuperar contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            label2.Location = new Point(44, 110);
            label2.Name = "label2";
            label2.Size = new Size(88, 29);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            txtNombre.Location = new Point(45, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 27);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            label3.Location = new Point(44, 180);
            label3.Name = "label3";
            label3.Size = new Size(78, 29);
            label3.TabIndex = 3;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            label4.Location = new Point(218, 108);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 4;
            label4.Text = "Usuario";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(45, 213);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(324, 27);
            txtCorreo.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            txtUsuario.Location = new Point(221, 143);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(148, 27);
            txtUsuario.TabIndex = 9;
            // 
            // btnEnviar
            // 
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.Black;
            btnEnviar.Location = new Point(147, 464);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(106, 41);
            btnEnviar.TabIndex = 10;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 358);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 14;
            label5.Text = "Repetir la Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 261);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 13;
            label6.Text = "Contraseña";
            // 
            // txtRepetir
            // 
            txtRepetir.Location = new Point(44, 406);
            txtRepetir.Margin = new Padding(4);
            txtRepetir.Name = "txtRepetir";
            txtRepetir.Size = new Size(142, 23);
            txtRepetir.TabIndex = 12;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(44, 303);
            txtContraseña.Margin = new Padding(4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(127, 23);
            txtContraseña.TabIndex = 11;
            // 
            // Recuperar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(449, 537);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtRepetir);
            Controls.Add(txtContraseña);
            Controls.Add(btnEnviar);
            Controls.Add(txtUsuario);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Recuperar";
            Text = "Recuperar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private TextBox txtCorreo;
        private TextBox txtUsuario;
        private Button btnEnviar;
        private Label label5;
        private Label label6;
        private TextBox txtRepetir;
        private TextBox txtContraseña;
    }
}