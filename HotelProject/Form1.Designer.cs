namespace HotelProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet8 = new HotelProject.Database2DataSet8();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet9 = new HotelProject.Database2DataSet9();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.database2DataSet6 = new HotelProject.Database2DataSet6();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new HotelProject.Database2DataSet6TableAdapters.ClientsTableAdapter();
            this.database2DataSet7 = new HotelProject.Database2DataSet7();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new HotelProject.Database2DataSet7TableAdapters.RoomsTableAdapter();
            this.clientsTableAdapter1 = new HotelProject.Database2DataSet8TableAdapters.ClientsTableAdapter();
            this.roomsTableAdapter1 = new HotelProject.Database2DataSet9TableAdapters.RoomsTableAdapter();
            this.database2DataSet10 = new HotelProject.Database2DataSet10();
            this.clientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter2 = new HotelProject.Database2DataSet10TableAdapters.ClientsTableAdapter();
            this.database2DataSet11 = new HotelProject.Database2DataSet11();
            this.roomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter2 = new HotelProject.Database2DataSet11TableAdapters.RoomsTableAdapter();
            this.database2DataSet12 = new HotelProject.Database2DataSet12();
            this.roomsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter3 = new HotelProject.Database2DataSet12TableAdapters.RoomsTableAdapter();
            this.database2DataSet13 = new HotelProject.Database2DataSet13();
            this.clientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter3 = new HotelProject.Database2DataSet13TableAdapters.ClientsTableAdapter();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(350, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.toolStripMenuItem1.Text = "Clients";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(162, 26);
            this.toolStripMenuItem4.Text = "Add Client";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(69, 24);
            this.toolStripMenuItem2.Text = "Rooms";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(164, 26);
            this.toolStripMenuItem7.Text = "Add Room";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date OUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientsBindingSource3, "Client_ID", true));
            this.comboBox1.DataSource = this.clientsBindingSource3;
            this.comboBox1.DisplayMember = "Client_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Client_ID";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.database2DataSet8;
            // 
            // database2DataSet8
            // 
            this.database2DataSet8.DataSetName = "Database2DataSet8";
            this.database2DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(115, 192);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource3, "Room_ID", true));
            this.comboBox2.DataSource = this.roomsBindingSource3;
            this.comboBox2.DisplayMember = "Room_Number";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "Room_Price";
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.database2DataSet9;
            // 
            // database2DataSet9
            // 
            this.database2DataSet9.DataSetName = "Database2DataSet9";
            this.database2DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "ALL REGISTRATIONS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // database2DataSet6
            // 
            this.database2DataSet6.DataSetName = "Database2DataSet6";
            this.database2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.database2DataSet6;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // database2DataSet7
            // 
            this.database2DataSet7.DataSetName = "Database2DataSet7";
            this.database2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.database2DataSet7;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // database2DataSet10
            // 
            this.database2DataSet10.DataSetName = "Database2DataSet10";
            this.database2DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource2
            // 
            this.clientsBindingSource2.DataMember = "Clients";
            this.clientsBindingSource2.DataSource = this.database2DataSet10;
            // 
            // clientsTableAdapter2
            // 
            this.clientsTableAdapter2.ClearBeforeFill = true;
            // 
            // database2DataSet11
            // 
            this.database2DataSet11.DataSetName = "Database2DataSet11";
            this.database2DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource2
            // 
            this.roomsBindingSource2.DataMember = "Rooms";
            this.roomsBindingSource2.DataSource = this.database2DataSet11;
            // 
            // roomsTableAdapter2
            // 
            this.roomsTableAdapter2.ClearBeforeFill = true;
            // 
            // database2DataSet12
            // 
            this.database2DataSet12.DataSetName = "Database2DataSet12";
            this.database2DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource3
            // 
            this.roomsBindingSource3.DataMember = "Rooms";
            this.roomsBindingSource3.DataSource = this.database2DataSet12;
            // 
            // roomsTableAdapter3
            // 
            this.roomsTableAdapter3.ClearBeforeFill = true;
            // 
            // database2DataSet13
            // 
            this.database2DataSet13.DataSetName = "Database2DataSet13";
            this.database2DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource3
            // 
            this.clientsBindingSource3.DataMember = "Clients";
            this.clientsBindingSource3.DataSource = this.database2DataSet13;
            // 
            // clientsTableAdapter3
            // 
            this.clientsTableAdapter3.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRoomsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Database2DataSet6 database2DataSet6;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Database2DataSet6TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private Database2DataSet7 database2DataSet7;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Database2DataSet7TableAdapters.RoomsTableAdapter roomsTableAdapter;
        private Database2DataSet8 database2DataSet8;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private Database2DataSet8TableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private Database2DataSet9 database2DataSet9;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private Database2DataSet9TableAdapters.RoomsTableAdapter roomsTableAdapter1;
        private Database2DataSet10 database2DataSet10;
        private System.Windows.Forms.BindingSource clientsBindingSource2;
        private Database2DataSet10TableAdapters.ClientsTableAdapter clientsTableAdapter2;
        private Database2DataSet11 database2DataSet11;
        private System.Windows.Forms.BindingSource roomsBindingSource2;
        private Database2DataSet11TableAdapters.RoomsTableAdapter roomsTableAdapter2;
        private Database2DataSet12 database2DataSet12;
        private System.Windows.Forms.BindingSource roomsBindingSource3;
        private Database2DataSet12TableAdapters.RoomsTableAdapter roomsTableAdapter3;
        private Database2DataSet13 database2DataSet13;
        private System.Windows.Forms.BindingSource clientsBindingSource3;
        private Database2DataSet13TableAdapters.ClientsTableAdapter clientsTableAdapter3;
    }
}

