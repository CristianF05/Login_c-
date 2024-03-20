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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-6, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F);
            textBox1.Location = new Point(344, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 26);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F);
            textBox2.Location = new Point(344, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 26);
            textBox2.TabIndex = 4;
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
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Aquamarine;
            button1.Location = new Point(412, 308);
            button1.MaximumSize = new Size(121, 38);
            button1.MinimumSize = new Size(121, 38);
            button1.Name = "button1";
            button1.Size = new Size(121, 38);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Aquamarine;
            label2.Location = new Point(344, 119);
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
            label3.Location = new Point(344, 194);
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
            linkLabel1.Location = new Point(344, 268);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(162, 21);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 50);
            ClientSize = new Size(621, 382);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
