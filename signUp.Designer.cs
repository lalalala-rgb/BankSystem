namespace BankSystem
{
    partial class signUp
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
            components = new System.ComponentModel.Container();
            txt_user = new TextBox();
            label1 = new Label();
            txt_pass = new TextBox();
            label2 = new Label();
            txt_acc = new TextBox();
            label3 = new Label();
            btn_register = new Button();
            btn_back = new Button();
            txt_OTP = new TextBox();
            label5 = new Label();
            btn_OTP = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txt_timer = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.WhiteSmoke;
            txt_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.ForeColor = Color.Black;
            txt_user.Location = new Point(166, 185);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(224, 29);
            txt_user.TabIndex = 4;
            txt_user.KeyPress += txt_user_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 185);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.WhiteSmoke;
            txt_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.ForeColor = Color.Black;
            txt_pass.Location = new Point(166, 232);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(224, 29);
            txt_pass.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 237);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // txt_acc
            // 
            txt_acc.BackColor = Color.WhiteSmoke;
            txt_acc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_acc.ForeColor = Color.Black;
            txt_acc.Location = new Point(166, 120);
            txt_acc.Name = "txt_acc";
            txt_acc.Size = new Size(224, 29);
            txt_acc.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 7;
            label3.Text = "Account No.";
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.WhiteSmoke;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_register.ForeColor = Color.Black;
            btn_register.Location = new Point(249, 371);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(103, 30);
            btn_register.TabIndex = 9;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.WhiteSmoke;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = Color.Black;
            btn_back.Location = new Point(82, 371);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(103, 30);
            btn_back.TabIndex = 10;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txt_OTP
            // 
            txt_OTP.BackColor = Color.WhiteSmoke;
            txt_OTP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_OTP.ForeColor = Color.Black;
            txt_OTP.Location = new Point(166, 292);
            txt_OTP.Name = "txt_OTP";
            txt_OTP.Size = new Size(93, 29);
            txt_OTP.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(55, 297);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 13;
            label5.Text = "OTP:";
            // 
            // btn_OTP
            // 
            btn_OTP.BackColor = Color.WhiteSmoke;
            btn_OTP.FlatAppearance.BorderSize = 0;
            btn_OTP.FlatStyle = FlatStyle.Flat;
            btn_OTP.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OTP.ForeColor = Color.Black;
            btn_OTP.Location = new Point(294, 293);
            btn_OTP.Name = "btn_OTP";
            btn_OTP.Size = new Size(96, 29);
            btn_OTP.TabIndex = 15;
            btn_OTP.Text = "Generate OTP";
            btn_OTP.UseVisualStyleBackColor = false;
            btn_OTP.Click += btn_OTP_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // txt_timer
            // 
            txt_timer.AutoSize = true;
            txt_timer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_timer.Location = new Point(358, 217);
            txt_timer.Name = "txt_timer";
            txt_timer.Size = new Size(0, 17);
            txt_timer.TabIndex = 16;
            txt_timer.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Glas__13_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.show;
            pictureBox3.Location = new Point(358, 236);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.hide;
            pictureBox4.Location = new Point(358, 236);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__15_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(505, 480);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txt_timer);
            Controls.Add(btn_OTP);
            Controls.Add(txt_OTP);
            Controls.Add(label5);
            Controls.Add(btn_back);
            Controls.Add(btn_register);
            Controls.Add(txt_acc);
            Controls.Add(label3);
            Controls.Add(txt_pass);
            Controls.Add(label2);
            Controls.Add(txt_user);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "signUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_user;
        private Label label1;
        private TextBox txt_pass;
        private Label label2;
        private TextBox txt_acc;
        private Label label3;
        private Button btn_register;
        private Button btn_back;
        private TextBox txt_OTP;
        private Label label5;
        private Button btn_OTP;
        private System.Windows.Forms.Timer timer1;
        private Label txt_timer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}