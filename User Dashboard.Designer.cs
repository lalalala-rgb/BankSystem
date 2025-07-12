namespace BankSystem
{
    partial class User_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Dashboard));
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            lblcustomer = new Label();
            button2 = new Button();
            btn_sendMoney = new Button();
            btn_payBills = new Button();
            btn_history = new Button();
            sideBartimer = new System.Windows.Forms.Timer(components);
            lblbalance = new Label();
            pictureBox1 = new PictureBox();
            btn_logout = new Button();
            label4 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(128, 144, 92);
            sidebar.BackgroundImage = (Image)resources.GetObject("sidebar.BackgroundImage");
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btn_sendMoney);
            sidebar.Controls.Add(btn_payBills);
            sidebar.Controls.Add(btn_history);
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(272, 661);
            sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(lblcustomer);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.MaximumSize = new Size(269, 219);
            panel2.MinimumSize = new Size(269, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 151);
            panel2.TabIndex = 1;
            // 
            // lblcustomer
            // 
            lblcustomer.AutoSize = true;
            lblcustomer.BackColor = Color.Transparent;
            lblcustomer.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblcustomer.ForeColor = Color.White;
            lblcustomer.Location = new Point(62, 72);
            lblcustomer.Name = "lblcustomer";
            lblcustomer.Size = new Size(65, 24);
            lblcustomer.TabIndex = 12;
            lblcustomer.Text = "label2";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 144);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(17, 0, 6, 0);
            button2.Size = new Size(257, 71);
            button2.TabIndex = 11;
            button2.Text = "        Settings";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_sendMoney
            // 
            btn_sendMoney.BackColor = Color.Transparent;
            btn_sendMoney.FlatAppearance.BorderSize = 0;
            btn_sendMoney.FlatStyle = FlatStyle.Flat;
            btn_sendMoney.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sendMoney.ForeColor = Color.White;
            btn_sendMoney.Image = (Image)resources.GetObject("btn_sendMoney.Image");
            btn_sendMoney.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sendMoney.Location = new Point(3, 163);
            btn_sendMoney.Margin = new Padding(3, 4, 3, 4);
            btn_sendMoney.Name = "btn_sendMoney";
            btn_sendMoney.Padding = new Padding(17, 0, 6, 0);
            btn_sendMoney.Size = new Size(257, 69);
            btn_sendMoney.TabIndex = 10;
            btn_sendMoney.Text = "        Send Money";
            btn_sendMoney.TextAlign = ContentAlignment.MiddleLeft;
            btn_sendMoney.UseVisualStyleBackColor = false;
            btn_sendMoney.Click += btn_sendMoney_Click;
            // 
            // btn_payBills
            // 
            btn_payBills.BackColor = Color.Transparent;
            btn_payBills.FlatAppearance.BorderSize = 0;
            btn_payBills.FlatStyle = FlatStyle.Flat;
            btn_payBills.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_payBills.ForeColor = Color.White;
            btn_payBills.Image = (Image)resources.GetObject("btn_payBills.Image");
            btn_payBills.ImageAlign = ContentAlignment.MiddleLeft;
            btn_payBills.Location = new Point(3, 240);
            btn_payBills.Margin = new Padding(3, 4, 3, 4);
            btn_payBills.Name = "btn_payBills";
            btn_payBills.Padding = new Padding(17, 0, 6, 0);
            btn_payBills.Size = new Size(257, 69);
            btn_payBills.TabIndex = 9;
            btn_payBills.Text = "         Pay Bills\r\n";
            btn_payBills.TextAlign = ContentAlignment.MiddleLeft;
            btn_payBills.UseVisualStyleBackColor = false;
            btn_payBills.Click += btn_payBills_Click;
            // 
            // btn_history
            // 
            btn_history.BackColor = Color.Transparent;
            btn_history.FlatAppearance.BorderSize = 0;
            btn_history.FlatStyle = FlatStyle.Flat;
            btn_history.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_history.ForeColor = Color.White;
            btn_history.Image = (Image)resources.GetObject("btn_history.Image");
            btn_history.ImageAlign = ContentAlignment.MiddleLeft;
            btn_history.Location = new Point(3, 317);
            btn_history.Margin = new Padding(3, 4, 3, 4);
            btn_history.Name = "btn_history";
            btn_history.Padding = new Padding(17, 0, 6, 0);
            btn_history.Size = new Size(272, 69);
            btn_history.TabIndex = 10;
            btn_history.Text = "Transaction \r\n History";
            btn_history.UseVisualStyleBackColor = false;
            btn_history.Click += btn_history_Click;
            // 
            // sideBartimer
            // 
            sideBartimer.Interval = 10;
            // 
            // lblbalance
            // 
            lblbalance.AutoSize = true;
            lblbalance.BackColor = Color.Transparent;
            lblbalance.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblbalance.Location = new Point(535, 291);
            lblbalance.Name = "lblbalance";
            lblbalance.Size = new Size(137, 54);
            lblbalance.TabIndex = 1;
            lblbalance.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(768, 605);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.WhiteSmoke;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.ForeColor = Color.Black;
            btn_logout.Location = new Point(801, 605);
            btn_logout.Margin = new Padding(3, 4, 3, 4);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(99, 40);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(425, 12);
            label4.Name = "label4";
            label4.Size = new Size(330, 43);
            label4.TabIndex = 39;
            label4.Text = "GLAS BANKING";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 300);
            label1.Name = "label1";
            label1.Size = new Size(250, 31);
            label1.TabIndex = 40;
            label1.Text = "Current Balance:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(415, 61);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(294, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // User_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 243, 237);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(915, 661);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btn_logout);
            Controls.Add(lblbalance);
            Controls.Add(sidebar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "User_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Dashboard";
            Load += User_Dashboard_Load;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Button button3;
        private Button btn_sendMoney;
        private Button btn_payBills;
        private Button btn_history;
        private Button button2;
        private System.Windows.Forms.Timer sideBartimer;
        private Label lblbalance;
        private Label lblcustomer;
        private PictureBox pictureBox1;
        private Button btn_logout;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox2;
    }
}