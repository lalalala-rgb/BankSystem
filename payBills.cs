using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace BankSystem
{
    public partial class payBills : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4Q2ON6T4\\SQLEXPRESS01;Integrated Security=True");
        private string username;
        public payBills(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        int ID = 0;
        private void payBills_Load(object sender, EventArgs e)
        {
            string[] role = { "Meralco", "Maynilad", "PLDT" };
            foreach (string roles in role)
            {
                comboBox1.Items.Add(roles);
            }
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT username FROM accounts WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);
           
            cmd.ExecuteNonQuery();
            con.Close();
            Auto_Increment();



        }


        private void btn_Payment_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO payBill VALUES(@transaction_id,@account_number,@amount,@bill_payment,@date)", con);
            System.DateTime myDate = default(System.DateTime);
            myDate = dateTimePicker1.Value;
            cmd.Parameters.AddWithValue("@transaction_id", int.Parse(txt_ID.Text));
            cmd.Parameters.AddWithValue("@account_number", txt_acc.Text);
            cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(txt_amount.Text));
            cmd.Parameters.AddWithValue("@bill_payment", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@date", myDate);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("UPDATE accounts SET balance -= @amount WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(txt_amount.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaction Succesfull!");




            string userInput = "*******************************************\n" + "**             Transaction Receipt               **\n" + "*******************************************" + "\n" + "Date: " + myDate + "\n" + "Amount: " + txt_amount.Text + "\n" + "Transaction ID: " + txt_ID.Text + "\n" + "Bill Paid:" + comboBox1.SelectedItem.ToString();
            Document document = new Document();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BillReceipt.pdf");
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph(userInput);
            document.Add(p);
            document.Close();
            MessageBox.Show("Receipt Printed!");
            con.Close();

            txt_amount.Clear();

            Auto_Increment();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Maynilad")
            {
                pictureBoxMaynilad.Visible = true;
                pictureBoxMaynilad.BringToFront();
            }
            else if (comboBox1.SelectedItem == "Meralco")
            {
                pictureBox2Meralco.Visible = true;
                pictureBox2Meralco.BringToFront();
            }
            else
            {
                pictureBoxPLDT.Visible = true;
                pictureBoxPLDT.BringToFront();
            }

        }
        private void Auto_Increment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(transaction_ID) from [payBill]", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            txt_ID.Text = ID + i.ToString();
        }

        private void btn_Backk_Click(object sender, EventArgs e)
        {
            User_Dashboard u = new User_Dashboard(username);
            u.Visible = true;
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
