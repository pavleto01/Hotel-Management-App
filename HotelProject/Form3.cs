using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class Form3 : Form
    {
        public string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavle\Desktop\HotelProject\HotelProject\DbContext\Database2.mdf;Integrated Security=True";

        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }
        private void DisplayData()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Clients", myConnection);
            adapt.Fill(dt);
            myConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(cs);
                myCommand = new SqlCommand("insert into Rooms(Room_Number,Room_Category,Room_Floor,Room_BedNum,Room_Price) values(@num,@category,@floor,@bednum,@price)",
                myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@num", textBox1.Text);
                myCommand.Parameters.AddWithValue("@category", comboBox1.GetItemText(comboBox1.SelectedItem));
                myCommand.Parameters.AddWithValue("@floor", textBox2.Text);
                myCommand.Parameters.AddWithValue("@bednum", textBox3.Text);
                myCommand.Parameters.AddWithValue("@price", textBox4.Text);
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
    }
}
