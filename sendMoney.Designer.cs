namespace BankSystem
{
    partial class sendMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendMoney));
            btn_Backk = new Button();
            label2 = new Label();
            label3 = new Label();
            btn_Payment = new Button();
            label4 = new Label();
            txt_amount = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            txt_toAcc = new TextBox();
            label5 = new Label();
            txt_fromAcc = new TextBox();
            txt_ID = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_Backk
            // 
            btn_Backk.BackColor = Color.White;
            btn_Backk.FlatAppearance.BorderSize = 0;
            btn_Backk.FlatStyle = FlatStyle.Flat;
            btn_Backk.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Backk.ForeColor = Color.Black;
            btn_Backk.Location = new Point(143, 468);
            btn_Backk.Margin = new Padding(3, 4, 3, 4);
            btn_Backk.Name = "btn_Backk";
            btn_Backk.Size = new Size(167, 41);
            btn_Backk.TabIndex = 48;
            btn_Backk.Text = "Back";
            btn_Backk.UseVisualStyleBackColor = false;
            btn_Backk.Click += btn_Backk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(152, 97);
            label2.Name = "label2";
            label2.Size = new Size(173, 24);
            label2.TabIndex = 39;
            label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(152, 161);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 40;
            label3.Text = "Date:";
            // 
            // btn_Payment
            // 
            btn_Payment.BackColor = Color.White;
            btn_Payment.FlatAppearance.BorderSize = 0;
            btn_Payment.FlatStyle = FlatStyle.Flat;
            btn_Payment.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Payment.ForeColor = Color.Black;
            btn_Payment.Location = new Point(389, 468);
            btn_Payment.Margin = new Padding(3, 4, 3, 4);
            btn_Payment.Name = "btn_Payment";
            btn_Payment.Size = new Size(167, 41);
            btn_Payment.TabIndex = 44;
            btn_Payment.Text = "Send Money";
            btn_Payment.UseVisualStyleBackColor = false;
            btn_Payment.Click += btn_Payment_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(152, 335);
            label4.Name = "label4";
            label4.Size = new Size(101, 24);
            label4.TabIndex = 42;
            label4.Text = "Amount:";
            // 
            // txt_amount
            // 
            txt_amount.BackColor = Color.White;
            txt_amount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_amount.ForeColor = Color.Black;
            txt_amount.Location = new Point(327, 335);
            txt_amount.Margin = new Padding(3, 4, 3, 4);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(191, 32);
            txt_amount.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.Location = new Point(327, 161);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(152, 272);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 50;
            label1.Text = "To Account No.";
            // 
            // txt_toAcc
            // 
            txt_toAcc.BackColor = Color.White;
            txt_toAcc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_toAcc.ForeColor = Color.Black;
            txt_toAcc.Location = new Point(327, 269);
            txt_toAcc.Margin = new Padding(3, 4, 3, 4);
            txt_toAcc.Name = "txt_toAcc";
            txt_toAcc.Size = new Size(191, 32);
            txt_toAcc.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(126, 215);
            label5.Name = "label5";
            label5.Size = new Size(199, 24);
            label5.TabIndex = 52;
            label5.Text = "From Account No.";
            // 
            // txt_fromAcc
            // 
            txt_fromAcc.BackColor = Color.White;
            txt_fromAcc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fromAcc.ForeColor = Color.Black;
            txt_fromAcc.Location = new Point(339, 211);
            txt_fromAcc.Margin = new Padding(3, 4, 3, 4);
            txt_fromAcc.Name = "txt_fromAcc";
            txt_fromAcc.Size = new Size(191, 32);
            txt_fromAcc.TabIndex = 51;
            // 
            // txt_ID
            // 
            txt_ID.AutoSize = true;
            txt_ID.BackColor = Color.Transparent;
            txt_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ID.ForeColor = Color.Black;
            txt_ID.Location = new Point(327, 93);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(23, 28);
            txt_ID.TabIndex = 53;
            txt_ID.Text = "a";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Glas__14_;
            pictureBox2.Location = new Point(655, 131);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(309, 291);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(702, 25);
            label6.Name = "label6";
            label6.Size = new Size(330, 43);
            label6.TabIndex = 56;
            label6.Text = "GLAS BANKING";
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 11);
            label7.Name = "label7";
            label7.Size = new Size(262, 60);
            label7.TabIndex = 57;
            label7.Text = "Send Money";
            label7.Visible = false;
            // 
            // sendMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1054, 575);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(txt_ID);
            Controls.Add(label5);
            Controls.Add(txt_fromAcc);
            Controls.Add(label1);
            Controls.Add(txt_toAcc);
            Controls.Add(btn_Backk);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btn_Payment);
            Controls.Add(label4);
            Controls.Add(txt_amount);
            Controls.Add(dateTimePicker1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "sendMoney";
            Text = "sendMoney";
            Load += sendMoney_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Backk;
        private Label label2;
        private Label label3;
        private Button btn_Payment;
        private Label label4;
        private TextBox txt_amount;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox txt_toAcc;
        private Label label5;
        private TextBox txt_fromAcc;
        private Label txt_ID;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
    }
}