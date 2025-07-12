namespace BankSystem
{
    partial class payBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payBills));
            btn_Back = new Button();
            btn_Payment = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            txt_amount = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            txt_acc = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            btn_Backk = new Button();
            txt_ID = new Label();
            pictureBoxPLDT = new PictureBox();
            pictureBox2Meralco = new PictureBox();
            pictureBoxMaynilad = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPLDT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Meralco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaynilad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(917, 809);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(125, 41);
            btn_Back.TabIndex = 29;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Payment
            // 
            btn_Payment.BackColor = Color.White;
            btn_Payment.FlatAppearance.BorderSize = 0;
            btn_Payment.FlatStyle = FlatStyle.Flat;
            btn_Payment.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Payment.ForeColor = Color.Black;
            btn_Payment.Location = new Point(421, 512);
            btn_Payment.Margin = new Padding(3, 4, 3, 4);
            btn_Payment.Name = "btn_Payment";
            btn_Payment.Size = new Size(129, 41);
            btn_Payment.TabIndex = 28;
            btn_Payment.Text = "Pay Bill";
            btn_Payment.UseVisualStyleBackColor = false;
            btn_Payment.Click += btn_Payment_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(662, 237);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(555, 317);
            label4.Name = "label4";
            label4.Size = new Size(101, 24);
            label4.TabIndex = 26;
            label4.Text = "Amount:";
            // 
            // txt_amount
            // 
            txt_amount.BackColor = Color.WhiteSmoke;
            txt_amount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_amount.ForeColor = Color.Black;
            txt_amount.Location = new Point(662, 305);
            txt_amount.Margin = new Padding(3, 4, 3, 4);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(191, 32);
            txt_amount.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(555, 237);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 24;
            label3.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 182);
            label2.Name = "label2";
            label2.Size = new Size(173, 24);
            label2.TabIndex = 21;
            label2.Text = "Transaction ID:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 313);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 28);
            comboBox1.TabIndex = 30;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 313);
            label5.Name = "label5";
            label5.Size = new Size(121, 24);
            label5.TabIndex = 31;
            label5.Text = "Bill to Pay:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txt_acc);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Backk);
            panel1.Controls.Add(txt_ID);
            panel1.Controls.Add(pictureBoxPLDT);
            panel1.Controls.Add(pictureBox2Meralco);
            panel1.Controls.Add(pictureBoxMaynilad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_Payment);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txt_amount);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 602);
            panel1.TabIndex = 33;
            panel1.Paint += panel1_Paint;
            // 
            // txt_acc
            // 
            txt_acc.BackColor = Color.WhiteSmoke;
            txt_acc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_acc.ForeColor = Color.Black;
            txt_acc.Location = new Point(173, 235);
            txt_acc.Margin = new Padding(3, 4, 3, 4);
            txt_acc.Name = "txt_acc";
            txt_acc.Size = new Size(191, 32);
            txt_acc.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(35, 240);
            label7.Name = "label7";
            label7.Size = new Size(138, 24);
            label7.TabIndex = 43;
            label7.Text = "Account No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(421, 12);
            label6.Name = "label6";
            label6.Size = new Size(330, 43);
            label6.TabIndex = 41;
            label6.Text = "GLAS BANKING";
            // 
            // label1
            // 
            label1.Font = new Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(203, 60);
            label1.TabIndex = 39;
            label1.Text = "Pay Bills";
            label1.Visible = false;
            // 
            // btn_Backk
            // 
            btn_Backk.BackColor = Color.WhiteSmoke;
            btn_Backk.FlatAppearance.BorderSize = 0;
            btn_Backk.FlatStyle = FlatStyle.Flat;
            btn_Backk.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Backk.ForeColor = Color.Black;
            btn_Backk.Location = new Point(208, 512);
            btn_Backk.Margin = new Padding(3, 4, 3, 4);
            btn_Backk.Name = "btn_Backk";
            btn_Backk.Size = new Size(113, 41);
            btn_Backk.TabIndex = 38;
            btn_Backk.Text = "Back";
            btn_Backk.UseVisualStyleBackColor = false;
            btn_Backk.Click += btn_Backk_Click;
            // 
            // txt_ID
            // 
            txt_ID.AutoSize = true;
            txt_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ID.ForeColor = Color.Black;
            txt_ID.Location = new Point(208, 178);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(0, 28);
            txt_ID.TabIndex = 36;
            // 
            // pictureBoxPLDT
            // 
            pictureBoxPLDT.Image = Properties.Resources.gdoqfLuP_400x400;
            pictureBoxPLDT.Location = new Point(183, 364);
            pictureBoxPLDT.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPLDT.Name = "pictureBoxPLDT";
            pictureBoxPLDT.Size = new Size(167, 104);
            pictureBoxPLDT.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPLDT.TabIndex = 35;
            pictureBoxPLDT.TabStop = false;
            pictureBoxPLDT.Visible = false;
            // 
            // pictureBox2Meralco
            // 
            pictureBox2Meralco.Image = Properties.Resources.Meralco;
            pictureBox2Meralco.Location = new Point(183, 364);
            pictureBox2Meralco.Margin = new Padding(3, 4, 3, 4);
            pictureBox2Meralco.Name = "pictureBox2Meralco";
            pictureBox2Meralco.Size = new Size(167, 104);
            pictureBox2Meralco.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2Meralco.TabIndex = 34;
            pictureBox2Meralco.TabStop = false;
            pictureBox2Meralco.Visible = false;
            // 
            // pictureBoxMaynilad
            // 
            pictureBoxMaynilad.Image = Properties.Resources.Maynilad_Logo_300x130_1;
            pictureBoxMaynilad.Location = new Point(183, 376);
            pictureBoxMaynilad.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMaynilad.Name = "pictureBoxMaynilad";
            pictureBoxMaynilad.Size = new Size(167, 104);
            pictureBoxMaynilad.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMaynilad.TabIndex = 33;
            pictureBoxMaynilad.TabStop = false;
            pictureBoxMaynilad.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Glas__14_2;
            pictureBox1.Location = new Point(538, 96);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // payBills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 602);
            Controls.Add(panel1);
            Controls.Add(btn_Back);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "payBills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "payBills";
            Load += payBills_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPLDT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Meralco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaynilad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Back;
        private Button btn_Payment;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox txt_amount;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBoxMaynilad;
        private PictureBox pictureBoxPLDT;
        private PictureBox pictureBox2Meralco;
        private Label txt_ID;
        private Button btn_Backk;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox txt_acc;
        private Label label7;
    }
}