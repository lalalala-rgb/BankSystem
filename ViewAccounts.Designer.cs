namespace BankSystem
{
    partial class ViewAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAccounts));
            dataGridView1 = new DataGridView();
            btn_Back = new Button();
            button2 = new Button();
            btn_Update = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            txt_acc = new Label();
            label2 = new Label();
            label9 = new Label();
            cmbAddress = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(390, 143);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(695, 461);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.ForeColor = Color.Black;
            btn_Back.Location = new Point(1101, 649);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(125, 41);
            btn_Back.TabIndex = 19;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(547, 612);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(125, 41);
            button2.TabIndex = 18;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.Black;
            btn_Update.Location = new Point(390, 612);
            btn_Update.Margin = new Padding(3, 4, 3, 4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(125, 41);
            btn_Update.TabIndex = 17;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txt_acc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cmbAddress);
            panel1.Controls.Add(btn_Back);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_Update);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 712);
            panel1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            // 
            // txt_acc
            // 
            txt_acc.AutoSize = true;
            txt_acc.BackColor = Color.Transparent;
            txt_acc.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_acc.ForeColor = Color.Black;
            txt_acc.Location = new Point(167, 204);
            txt_acc.Name = "txt_acc";
            txt_acc.Size = new Size(21, 24);
            txt_acc.TabIndex = 56;
            txt_acc.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 199);
            label2.Name = "label2";
            label2.Size = new Size(165, 29);
            label2.TabIndex = 55;
            label2.Text = "Account No.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(94, 274);
            label9.Name = "label9";
            label9.Size = new Size(50, 25);
            label9.TabIndex = 53;
            label9.Text = "+63 ";
            // 
            // cmbAddress
            // 
            cmbAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAddress.ForeColor = Color.Black;
            cmbAddress.FormattingEnabled = true;
            cmbAddress.Location = new Point(97, 408);
            cmbAddress.Margin = new Padding(3, 4, 3, 4);
            cmbAddress.Name = "cmbAddress";
            cmbAddress.Size = new Size(186, 36);
            cmbAddress.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 343);
            label5.Name = "label5";
            label5.Size = new Size(77, 24);
            label5.TabIndex = 51;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 415);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 47;
            label3.Text = "City:";
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.White;
            txt_email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.ForeColor = Color.Black;
            txt_email.Location = new Point(97, 337);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(243, 32);
            txt_email.TabIndex = 50;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.White;
            txt_phone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.ForeColor = Color.Black;
            txt_phone.Location = new Point(150, 271);
            txt_phone.Margin = new Padding(3, 4, 3, 4);
            txt_phone.MaxLength = 10;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(190, 32);
            txt_phone.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 276);
            label4.Name = "label4";
            label4.Size = new Size(83, 24);
            label4.TabIndex = 49;
            label4.Text = "Phone:";
            // 
            // ViewAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 243, 237);
            ClientSize = new Size(1246, 712);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_Account";
            Load += add_Account_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btn_Back;
        private Button button2;
        private Button btn_Update;
        private Panel panel1;
        private Label label9;
        private ComboBox cmbAddress;
        private Label label5;
        private Label label3;
        private TextBox txt_email;
        private TextBox txt_phone;
        private Label label4;
        private Label label2;
        private Label txt_acc;
        private PictureBox pictureBox2;
    }
}