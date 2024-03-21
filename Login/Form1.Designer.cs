namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnContraseña = new TextBox();
            btnUsuario = new TextBox();
            label1 = new Label();
            btnIngresar = new Button();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnContraseña
            // 
            btnContraseña.Font = new Font("Arial", 12F);
            btnContraseña.Location = new Point(358, 210);
            btnContraseña.Name = "btnContraseña";
            btnContraseña.Size = new Size(223, 26);
            btnContraseña.TabIndex = 3;
            btnContraseña.TextChanged += btnContraseña_TextChanged;
            // 
            // btnUsuario
            // 
            btnUsuario.Font = new Font("Arial", 12F);
            btnUsuario.Location = new Point(358, 129);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(223, 26);
            btnUsuario.TabIndex = 4;
            btnUsuario.TextChanged += btnUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 50);
            label1.Font = new Font("Bell MT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aquamarine;
            label1.Location = new Point(392, 25);
            label1.Name = "label1";
            label1.Size = new Size(141, 54);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkCyan;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.Aquamarine;
            btnIngresar.Location = new Point(412, 321);
            btnIngresar.MaximumSize = new Size(121, 38);
            btnIngresar.MinimumSize = new Size(121, 38);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(121, 38);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Aquamarine;
            label2.Location = new Point(358, 96);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 7;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Aquamarine;
            label3.Location = new Point(358, 171);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 8;
            label3.Text = "Contraseña";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Cyan;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Turquoise;
            linkLabel1.Location = new Point(358, 245);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(162, 21);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar contraseña";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Cyan;
            linkLabel2.AutoSize = true;
            linkLabel2.DisabledLinkColor = Color.White;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Turquoise;
            linkLabel2.Location = new Point(358, 282);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(103, 21);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Crear Cuenta";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Aquamarine;
            label.Location = new Point(108, 287);
            label.Name = "label";
            label.Size = new Size(139, 32);
            label.TabIndex = 11;
            label.Text = "Debelopers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 50);
            ClientSize = new Size(621, 382);
            Controls.Add(label);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Controls.Add(btnUsuario);
            Controls.Add(btnContraseña);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(637, 421);
            MinimumSize = new Size(637, 421);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox btnContraseña;
        private TextBox btnUsuario;
        private Label label1;
        private Button btnIngresar;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label;
    }
}
