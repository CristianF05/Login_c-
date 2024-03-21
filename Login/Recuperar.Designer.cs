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
            btnEnviar.Location = new Point(150, 273);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(106, 41);
            btnEnviar.TabIndex = 10;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Recuperar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(449, 381);
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
    }
}