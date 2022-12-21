using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet3.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.database2DataSet3.Registration);

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet15.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter2.Fill(this.database2DataSet15.Registration);
            // TODO: This line of code loads data into the 'database2DataSet5.Registration' table. You can move, or remove it, as needed.
            

        }
    }
}
