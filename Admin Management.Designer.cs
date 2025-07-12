namespace BankSystem
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            sideBarTime = new System.Windows.Forms.Timer(components);
            transactionTime = new System.Windows.Forms.Timer(components);
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            btn_Withdraw = new Button();
            btn_account = new Button();
            Btn_NewCustomer = new Button();
            panel1 = new Panel();
            btn_Menu = new PictureBox();
            label1 = new Label();
            sideBar = new FlowLayoutPanel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).BeginInit();
            sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(861, 389);
            button2.Name = "button2";
            button2.Size = new Size(87, 30);
            button2.TabIndex = 6;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(831, 389);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // sideBarTime
            // 
            sideBarTime.Interval = 1;
            sideBarTime.Tick += timer1_Tick;
            // 
            // transactionTime
            // 
            transactionTime.Interval = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(528, 172);
            label2.Name = "label2";
            label2.Size = new Size(117, 24);
            label2.TabIndex = 33;
            label2.Text = "ABOUT US";
            // 
            // btn_Withdraw
            // 
            btn_Withdraw.BackColor = Color.Transparent;
            btn_Withdraw.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Withdraw.FlatAppearance.BorderSize = 0;
            btn_Withdraw.FlatStyle = FlatStyle.Flat;
            btn_Withdraw.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Withdraw.ForeColor = SystemColors.Control;
            btn_Withdraw.Image = Properties.Resources.money_withdrawal;
            btn_Withdraw.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Withdraw.Location = new Point(3, 217);
            btn_Withdraw.Name = "btn_Withdraw";
            btn_Withdraw.Padding = new Padding(15, 0, 5, 0);
            btn_Withdraw.Size = new Size(222, 52);
            btn_Withdraw.TabIndex = 11;
            btn_Withdraw.Text = "         Withdraw/Deposit";
            btn_Withdraw.TextAlign = ContentAlignment.MiddleLeft;
            btn_Withdraw.UseVisualStyleBackColor = false;
            btn_Withdraw.Click += btn_Withdraw_Click_1;
            // 
            // btn_account
            // 
            btn_account.BackColor = Color.Transparent;
            btn_account.BackgroundImageLayout = ImageLayout.Stretch;
            btn_account.FlatAppearance.BorderSize = 0;
            btn_account.FlatStyle = FlatStyle.Flat;
            btn_account.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_account.ForeColor = Color.White;
            btn_account.Image = Properties.Resources.search;
            btn_account.ImageAlign = ContentAlignment.MiddleLeft;
            btn_account.Location = new Point(3, 159);
            btn_account.Name = "btn_account";
            btn_account.Padding = new Padding(15, 0, 5, 0);
            btn_account.Size = new Size(222, 52);
            btn_account.TabIndex = 15;
            btn_account.Text = "         View";
            btn_account.TextAlign = ContentAlignment.MiddleLeft;
            btn_account.UseVisualStyleBackColor = false;
            btn_account.Click += btn_account_Click_1;
            // 
            // Btn_NewCustomer
            // 
            Btn_NewCustomer.BackColor = Color.Transparent;
            Btn_NewCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_NewCustomer.FlatAppearance.BorderSize = 0;
            Btn_NewCustomer.FlatStyle = FlatStyle.Flat;
            Btn_NewCustomer.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_NewCustomer.ForeColor = Color.White;
            Btn_NewCustomer.Image = Properties.Resources.people_Icon1;
            Btn_NewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_NewCustomer.Location = new Point(3, 101);
            Btn_NewCustomer.Name = "Btn_NewCustomer";
            Btn_NewCustomer.Padding = new Padding(15, 0, 5, 0);
            Btn_NewCustomer.Size = new Size(225, 52);
            Btn_NewCustomer.TabIndex = 4;
            Btn_NewCustomer.Text = "         Account";
            Btn_NewCustomer.TextAlign = ContentAlignment.MiddleLeft;
            Btn_NewCustomer.UseVisualStyleBackColor = false;
            Btn_NewCustomer.Click += Btn_NewCustomer_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btn_Menu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 94);
            panel1.TabIndex = 0;
            // 
            // btn_Menu
            // 
            btn_Menu.BackColor = Color.Transparent;
            btn_Menu.Cursor = Cursors.Hand;
            btn_Menu.Image = Properties.Resources.menu;
            btn_Menu.Location = new Point(19, 30);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(24, 24);
            btn_Menu.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_Menu.TabIndex = 8;
            btn_Menu.TabStop = false;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(49, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 8;
            label1.Text = "Menu";
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.Transparent;
            sideBar.BackgroundImage = (Image)resources.GetObject("sideBar.BackgroundImage");
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(Btn_NewCustomer);
            sideBar.Controls.Add(btn_account);
            sideBar.Controls.Add(btn_Withdraw);
            sideBar.Location = new Point(-3, 0);
            sideBar.Margin = new Padding(3, 2, 3, 2);
            sideBar.MaximumSize = new Size(232, 431);
            sideBar.MinimumSize = new Size(58, 431);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(232, 431);
            sideBar.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(347, 196);
            label3.Name = "label3";
            label3.Size = new Size(484, 115);
            label3.TabIndex = 36;
            label3.Text = "At GLAS Banking we are committed to \r\nproviding exceptional banking services\r\n to our valued customers. \r\nWe have built a strong reputation for reliability,\r\n trustworthiness, and innovation.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(517, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(471, 9);
            label4.Name = "label4";
            label4.Size = new Size(258, 34);
            label4.TabIndex = 38;
            label4.Text = "GLAS BANKING";
            label4.Click += label4_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 433);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sideBar);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Management";
            Load += Management_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).EndInit();
            sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Deposit;
        private Button button2;
        private Button button5;
        private Button button3;
        private System.Windows.Forms.Timer sideBarTime;
        private System.Windows.Forms.Timer transactionTime;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        private Label label2;
        private Button btn_Withdraw;
        private Button btn_account;
        private Button Btn_NewCustomer;
        private Panel panel1;
        private PictureBox btn_Menu;
        private Label label1;
        private FlowLayoutPanel sideBar;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
    }
}