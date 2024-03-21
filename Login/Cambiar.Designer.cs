namespace Login
{
    partial class Cambiar
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
            txtContraseña = new TextBox();
            txtRepetir = new TextBox();
            btnCambiar = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 0;
            label1.Text = "Cambiar Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(40, 195);
            txtContraseña.Margin = new Padding(4, 4, 4, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(127, 26);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextChanged += textBox1_TextChanged;
            // 
            // txtRepetir
            // 
            txtRepetir.Location = new Point(40, 298);
            txtRepetir.Margin = new Padding(4, 4, 4, 4);
            txtRepetir.Name = "txtRepetir";
            txtRepetir.Size = new Size(142, 26);
            txtRepetir.TabIndex = 2;
            // 
            // btnCambiar
            // 
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiar.ForeColor = Color.White;
            btnCambiar.Location = new Point(120, 372);
            btnCambiar.Margin = new Padding(4, 4, 4, 4);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(102, 39);
            btnCambiar.TabIndex = 3;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 250);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 5;
            label3.Text = "Repetir la Contraseña";
            // 
            // Cambiar
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(401, 496);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCambiar);
            Controls.Add(txtRepetir);
            Controls.Add(txtContraseña);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Cambiar";
            Text = "Cambiar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContraseña;
        private TextBox txtRepetir;
        private Button btnCambiar;
        private Label label2;
        private Label label3;
    }
}