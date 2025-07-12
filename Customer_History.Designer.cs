namespace BankSystem
{
    partial class Customer_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_History));
            dataGridView1 = new DataGridView();
            btn_back = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btn_payBills = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(244, 245, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(160, 103);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(589, 365);
            dataGridView1.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.AutoSize = true;
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.Location = new Point(373, 520);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(139, 41);
            btn_back.TabIndex = 2;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(373, 36);
            label4.Name = "label4";
            label4.Size = new Size(446, 43);
            label4.TabIndex = 39;
            label4.Text = "CUSTOMER HISTORY";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 88);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // btn_payBills
            // 
            btn_payBills.AutoSize = true;
            btn_payBills.BackColor = SystemColors.ControlLightLight;
            btn_payBills.FlatStyle = FlatStyle.Flat;
            btn_payBills.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_payBills.Location = new Point(228, 476);
            btn_payBills.Margin = new Padding(3, 4, 3, 4);
            btn_payBills.Name = "btn_payBills";
            btn_payBills.Size = new Size(139, 41);
            btn_payBills.TabIndex = 41;
            btn_payBills.Text = "Paybills";
            btn_payBills.UseVisualStyleBackColor = false;
            btn_payBills.Click += btn_payBills_Click;
            // 
            // Customer_History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_payBills);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btn_back);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customer_History";
            Text = "Customer_History";
            Load += Customer_History_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_back;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btn_payBills;
    }
}