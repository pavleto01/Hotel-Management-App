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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet17.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.database2DataSet17.Clients);
            // TODO: This line of code loads data into the 'database2DataSet1.Clients' table. You can move, or remove it, as needed.
            

        }
    }
}
