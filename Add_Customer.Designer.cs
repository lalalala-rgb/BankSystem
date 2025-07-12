namespace BankSystem
{
    partial class Add_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Customer));
            label4 = new Label();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            txt_first = new TextBox();
            btn_Back = new Button();
            label1 = new Label();
            txt_ID = new Label();
            cmbAddress = new ComboBox();
            label6 = new Label();
            txt_last = new TextBox();
            label7 = new Label();
            txt_middle = new TextBox();
            label8 = new Label();
            txt_balance = new TextBox();
            btn_Add = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(106, 266);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 8;
            label4.Text = "Phone:";
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.White;
            txt_phone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.ForeColor = Color.Black;
            txt_phone.Location = new Point(218, 263);
            txt_phone.MaxLength = 10;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(154, 27);
            txt_phone.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.White;
            txt_email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.ForeColor = Color.Black;
            txt_email.Location = new Point(441, 263);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(163, 27);
            txt_email.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(620, 267);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 6;
            label3.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(378, 267);
            label5.Name = "label5";
            label5.Size = new Size(63, 18);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(106, 183);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 4;
            label2.Text = "First Name:";
            // 
            // txt_first
            // 
            txt_first.BackColor = Color.White;
            txt_first.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_first.ForeColor = Color.Black;
            txt_first.Location = new Point(218, 179);
            txt_first.Name = "txt_first";
            txt_first.Size = new Size(154, 27);
            txt_first.TabIndex = 3;
            txt_first.KeyPress += txt_name_KeyPress;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.ForeColor = Color.Black;
            btn_Back.Location = new Point(119, 423);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(109, 31);
            btn_Back.TabIndex = 15;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(119, 122);
            label1.Name = "label1";
            label1.Size = new Size(161, 18);
            label1.TabIndex = 2;
            label1.Text = "Account_Number:";
            // 
            // txt_ID
            // 
            txt_ID.AutoSize = true;
            txt_ID.BackColor = Color.Transparent;
            txt_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ID.ForeColor = Color.Black;
            txt_ID.Location = new Point(274, 120);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(27, 21);
            txt_ID.TabIndex = 34;
            txt_ID.Text = "ID";
            // 
            // cmbAddress
            // 
            cmbAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAddress.ForeColor = Color.Black;
            cmbAddress.FormattingEnabled = true;
            cmbAddress.Location = new Point(673, 261);
            cmbAddress.Name = "cmbAddress";
            cmbAddress.Size = new Size(148, 29);
            cmbAddress.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(381, 183);
            label6.Name = "label6";
            label6.Size = new Size(102, 18);
            label6.TabIndex = 40;
            label6.Text = "Last Name:";
            // 
            // txt_last
            // 
            txt_last.BackColor = Color.White;
            txt_last.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_last.ForeColor = Color.Black;
            txt_last.Location = new Point(489, 179);
            txt_last.Name = "txt_last";
            txt_last.Size = new Size(143, 27);
            txt_last.TabIndex = 39;
            txt_last.KeyPress += txt_last_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(638, 183);
            label7.Name = "label7";
            label7.Size = new Size(124, 18);
            label7.TabIndex = 42;
            label7.Text = "Middle Name:";
            // 
            // txt_middle
            // 
            txt_middle.BackColor = Color.White;
            txt_middle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_middle.ForeColor = Color.Black;
            txt_middle.Location = new Point(768, 179);
            txt_middle.Name = "txt_middle";
            txt_middle.Size = new Size(157, 27);
            txt_middle.TabIndex = 41;
            txt_middle.KeyPress += txt_middle_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(119, 346);
            label8.Name = "label8";
            label8.Size = new Size(80, 18);
            label8.TabIndex = 45;
            label8.Text = "Balance:";
            // 
            // txt_balance
            // 
            txt_balance.BackColor = Color.White;
            txt_balance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_balance.ForeColor = Color.Black;
            txt_balance.Location = new Point(218, 342);
            txt_balance.MaxLength = 10;
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(154, 27);
            txt_balance.TabIndex = 44;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.ForeColor = Color.Black;
            btn_Add.Location = new Point(254, 423);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(109, 31);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Submit";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 144, 92);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_balance);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_middle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_last);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbAddress);
            panel1.Controls.Add(txt_ID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Back);
            panel1.Controls.Add(btn_Add);
            panel1.Controls.Add(txt_first);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 548);
            panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(178, 267);
            label9.Name = "label9";
            label9.Size = new Size(40, 21);
            label9.TabIndex = 46;
            label9.Text = "+63 ";
            label9.Click += label9_Click;
            // 
            // Add_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 243, 237);
            ClientSize = new Size(1036, 548);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Customer";
            Load += Add_Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private TextBox txt_phone;
        private TextBox txt_email;
        private Label label3;
        private Label label5;
        private Label label2;
        private TextBox txt_first;
        private Button btn_Back;
        private Label label1;
        private Label txt_ID;
        private ComboBox cmbAddress;
        private Label label6;
        private TextBox txt_last;
        private Label label7;
        private TextBox txt_middle;
        private Label label8;
        private TextBox txt_balance;
        private Button btn_Add;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox2;
    }
}