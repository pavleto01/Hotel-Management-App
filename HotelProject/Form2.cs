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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(cs);
                myCommand = new SqlCommand("insert into Clients(Client_EGN,Client_Name,Client_Address,Client_IdCard) values(@egn,@name,@address,@idcard)",
                myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@egn", textBox1.Text);
                myCommand.Parameters.AddWithValue("@name", textBox2.Text);
                myCommand.Parameters.AddWithValue("@address", textBox3.Text);
                myCommand.Parameters.AddWithValue("@idcard", textBox4.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }
    }
}
