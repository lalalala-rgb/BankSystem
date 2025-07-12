namespace BankSystem
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            label1 = new Label();
            txtUser = new TextBox();
            txtPw = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Login = new Button();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lbl_register = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(19, 180);
            label1.Name = "label1";
            label1.Size = new Size(98, 18);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.ControlLightLight;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(121, 176);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(224, 29);
            txtUser.TabIndex = 2;
            // 
            // txtPw
            // 
            txtPw.BackColor = SystemColors.ControlLightLight;
            txtPw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPw.ForeColor = Color.Black;
            txtPw.Location = new Point(121, 234);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.Size = new Size(224, 29);
            txtPw.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 239);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(105, 113);
            label3.Name = "label3";
            label3.Size = new Size(274, 27);
            label3.TabIndex = 8;
            label3.Text = "Log in to Your Account";
            // 
            // Login
            // 
            Login.BackColor = Color.WhiteSmoke;
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.Black;
            Login.Location = new Point(176, 342);
            Login.Name = "Login";
            Login.Size = new Size(103, 30);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(121, 275);
            label6.Name = "label6";
            label6.Size = new Size(155, 18);
            label6.TabIndex = 9;
            label6.Text = "Forgot Password?";
            label6.Click += label6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.show;
            pictureBox3.Location = new Point(308, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.hide;
            pictureBox4.Location = new Point(308, 239);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // lbl_register
            // 
            lbl_register.AutoSize = true;
            lbl_register.BackColor = Color.LightSkyBlue;
            lbl_register.Cursor = Cursors.Hand;
            lbl_register.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_register.ForeColor = Color.Black;
            lbl_register.Location = new Point(121, 300);
            lbl_register.Name = "lbl_register";
            lbl_register.Size = new Size(116, 18);
            lbl_register.TabIndex = 13;
            lbl_register.Text = "Register Now";
            lbl_register.Click += lbl_register_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Glas__14_3;
            pictureBox1.Location = new Point(677, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 243, 237);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 433);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_register);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtPw);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(Login);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPw;
        private Label label2;
        private Label label3;
        private Button Login;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lbl_register;
        private PictureBox pictureBox1;
    }
}