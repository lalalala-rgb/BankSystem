namespace BankSystem
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            label2 = new Label();
            label1 = new Label();
            txt_acc = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_amount = new TextBox();
            btn_withdraw = new Button();
            dataGridView1 = new DataGridView();
            btn_Back = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_ID = new Label();
            button1 = new Button();
            label6 = new Label();
            txt_search = new TextBox();
            btn_View = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 180);
            label2.Name = "label2";
            label2.Size = new Size(207, 29);
            label2.TabIndex = 8;
            label2.Text = "Transaction ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 241);
            label1.Name = "label1";
            label1.Size = new Size(165, 29);
            label1.TabIndex = 10;
            label1.Text = "Account No.";
            // 
            // txt_acc
            // 
            txt_acc.BackColor = Color.WhiteSmoke;
            txt_acc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_acc.ForeColor = Color.Black;
            txt_acc.Location = new Point(17, 288);
            txt_acc.Margin = new Padding(3, 4, 3, 4);
            txt_acc.Name = "txt_acc";
            txt_acc.Size = new Size(191, 32);
            txt_acc.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 357);
            label3.Name = "label3";
            label3.Size = new Size(80, 29);
            label3.TabIndex = 12;
            label3.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 305);
            label4.Name = "label4";
            label4.Size = new Size(123, 29);
            label4.TabIndex = 14;
            label4.Text = "Amount:";
            // 
            // txt_amount
            // 
            txt_amount.BackColor = Color.WhiteSmoke;
            txt_amount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_amount.ForeColor = Color.Black;
            txt_amount.Location = new Point(33, 357);
            txt_amount.Margin = new Padding(3, 4, 3, 4);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(191, 32);
            txt_amount.TabIndex = 13;
            // 
            // btn_withdraw
            // 
            btn_withdraw.BackColor = Color.WhiteSmoke;
            btn_withdraw.FlatAppearance.BorderSize = 0;
            btn_withdraw.FlatStyle = FlatStyle.Flat;
            btn_withdraw.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_withdraw.ForeColor = Color.Black;
            btn_withdraw.Location = new Point(66, 481);
            btn_withdraw.Margin = new Padding(3, 4, 3, 4);
            btn_withdraw.Name = "btn_withdraw";
            btn_withdraw.Size = new Size(129, 47);
            btn_withdraw.TabIndex = 16;
            btn_withdraw.Text = "Proceed";
            btn_withdraw.UseVisualStyleBackColor = false;
            btn_withdraw.Click += btn_withdraw_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(319, 51);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(586, 361);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(637, 817);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(125, 41);
            btn_Back.TabIndex = 19;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 197);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 36);
            comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(33, 141);
            label5.Name = "label5";
            label5.Size = new Size(235, 29);
            label5.TabIndex = 21;
            label5.Text = "Transaction Type:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 124, 194);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txt_ID);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_acc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 639);
            panel1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(26, 51);
            label7.Name = "label7";
            label7.Size = new Size(252, 43);
            label7.TabIndex = 34;
            label7.Text = "GLAS BANK";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 399);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(218, 27);
            dateTimePicker1.TabIndex = 33;
            // 
            // txt_ID
            // 
            txt_ID.AutoSize = true;
            txt_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ID.ForeColor = Color.White;
            txt_ID.Location = new Point(205, 123);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(0, 28);
            txt_ID.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(67, 484);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(105, 47);
            button1.TabIndex = 31;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(370, 467);
            label6.Name = "label6";
            label6.Size = new Size(126, 28);
            label6.TabIndex = 40;
            label6.Text = "Transaction:";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(520, 469);
            txt_search.Margin = new Padding(3, 4, 3, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(263, 27);
            txt_search.TabIndex = 39;
            // 
            // btn_View
            // 
            btn_View.BackColor = Color.WhiteSmoke;
            btn_View.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_View.Location = new Point(506, 536);
            btn_View.Margin = new Padding(3, 4, 3, 4);
            btn_View.Name = "btn_View";
            btn_View.Size = new Size(233, 43);
            btn_View.TabIndex = 38;
            btn_View.Text = "Search";
            btn_View.UseVisualStyleBackColor = false;
            btn_View.Click += btn_View_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(txt_amount);
            panel2.Controls.Add(btn_withdraw);
            panel2.Location = new Point(923, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 639);
            panel2.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 243, 237);
            ClientSize = new Size(1234, 639);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(txt_search);
            Controls.Add(btn_View);
            Controls.Add(btn_Back);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdraw";
            Load += Withdraw_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_acc;
        private Label label3;
        private Label label4;
        private TextBox txt_amount;
        private Button btn_withdraw;
        private DataGridView dataGridView1;
        private Button btn_Back;
        private ComboBox comboBox1;
        private Label label5;
        private Panel panel1;
        private Label txt_ID;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txt_search;
        private Button btn_View;
        private Panel panel2;
        private Label label7;
        private PictureBox pictureBox1;
    }
}