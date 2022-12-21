using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelProject
{
    public partial class Form1 : Form
    {
        public string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavle\Desktop\HotelProject\HotelProject\DbContext\Database2.mdf;Integrated Security=True";

        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;
        private void DisplayData()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Clients", myConnection);
            adapt.Fill(dt);
            myConnection.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(cs);
                myCommand = new SqlCommand("insert into Registration(Registration_DocDate,RClient_ID,RRoom_ID,Registration_DateIn,Registration_DateOut,Registration_SumPrice) values(@date,@client,@room,@datein,@dateout,@price)",
                myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@date", DateTime.Now);
                myCommand.Parameters.AddWithValue("@client", comboBox1.GetItemText(comboBox1.SelectedValue));
                myCommand.Parameters.AddWithValue("@room", comboBox2.GetItemText(comboBox2.SelectedValue));
                myCommand.Parameters.AddWithValue("@datein", dateTimePicker1.Value);
                myCommand.Parameters.AddWithValue("@dateout", dateTimePicker2.Value);
                DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);
                var days = outTime.Subtract(inTime).Days;
                var price = days * float.Parse(comboBox2.GetItemText(comboBox2.ValueMember));
                myCommand.Parameters.AddWithValue("@price", price);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Insert successfully!");
                DisplayData();
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet13.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter3.Fill(this.database2DataSet13.Clients);
            // TODO: This line of code loads data into the 'database2DataSet12.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter3.Fill(this.database2DataSet12.Rooms);
            

        }
    }
}
