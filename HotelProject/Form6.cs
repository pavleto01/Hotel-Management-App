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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet19.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter3.Fill(this.database2DataSet19.Rooms);
            // TODO: This line of code loads data into the 'database2DataSet18.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter2.Fill(this.database2DataSet18.Rooms);
            // TODO: This line of code loads data into the 'database2DataSet4.Rooms' table. You can move, or remove it, as needed.
            
            

        }
    }
}
