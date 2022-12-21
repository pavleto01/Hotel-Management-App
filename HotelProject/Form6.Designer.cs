namespace HotelProject
{
    partial class Form6
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
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet2 = new HotelProject.Database2DataSet2();
            this.roomsTableAdapter = new HotelProject.Database2DataSet2TableAdapters.RoomsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomFloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBedNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet4 = new HotelProject.Database2DataSet4();
            this.roomsTableAdapter1 = new HotelProject.Database2DataSet4TableAdapters.RoomsTableAdapter();
            this.database2DataSet18 = new HotelProject.Database2DataSet18();
            this.roomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter2 = new HotelProject.Database2DataSet18TableAdapters.RoomsTableAdapter();
            this.database2DataSet19 = new HotelProject.Database2DataSet19();
            this.roomsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter3 = new HotelProject.Database2DataSet19TableAdapters.RoomsTableAdapter();
            this.Room_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.database2DataSet2;
            // 
            // database2DataSet2
            // 
            this.database2DataSet2.DataSetName = "Database2DataSet2";
            this.database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.roomCategoryDataGridViewTextBoxColumn,
            this.roomFloorDataGridViewTextBoxColumn,
            this.roomBedNumDataGridViewTextBoxColumn,
            this.Room_Price});
            this.dataGridView1.DataSource = this.roomsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(35, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(864, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomCategoryDataGridViewTextBoxColumn
            // 
            this.roomCategoryDataGridViewTextBoxColumn.DataPropertyName = "Room_Category";
            this.roomCategoryDataGridViewTextBoxColumn.HeaderText = "Room_Category";
            this.roomCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomCategoryDataGridViewTextBoxColumn.Name = "roomCategoryDataGridViewTextBoxColumn";
            this.roomCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomFloorDataGridViewTextBoxColumn
            // 
            this.roomFloorDataGridViewTextBoxColumn.DataPropertyName = "Room_Floor";
            this.roomFloorDataGridViewTextBoxColumn.HeaderText = "Room_Floor";
            this.roomFloorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomFloorDataGridViewTextBoxColumn.Name = "roomFloorDataGridViewTextBoxColumn";
            this.roomFloorDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomBedNumDataGridViewTextBoxColumn
            // 
            this.roomBedNumDataGridViewTextBoxColumn.DataPropertyName = "Room_BedNum";
            this.roomBedNumDataGridViewTextBoxColumn.HeaderText = "Room_BedNum";
            this.roomBedNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomBedNumDataGridViewTextBoxColumn.Name = "roomBedNumDataGridViewTextBoxColumn";
            this.roomBedNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.database2DataSet4;
            // 
            // database2DataSet4
            // 
            this.database2DataSet4.DataSetName = "Database2DataSet4";
            this.database2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // database2DataSet18
            // 
            this.database2DataSet18.DataSetName = "Database2DataSet18";
            this.database2DataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource2
            // 
            this.roomsBindingSource2.DataMember = "Rooms";
            this.roomsBindingSource2.DataSource = this.database2DataSet18;
            // 
            // roomsTableAdapter2
            // 
            this.roomsTableAdapter2.ClearBeforeFill = true;
            // 
            // database2DataSet19
            // 
            this.database2DataSet19.DataSetName = "Database2DataSet19";
            this.database2DataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource3
            // 
            this.roomsBindingSource3.DataMember = "Rooms";
            this.roomsBindingSource3.DataSource = this.database2DataSet19;
            // 
            // roomsTableAdapter3
            // 
            this.roomsTableAdapter3.ClearBeforeFill = true;
            // 
            // Room_Price
            // 
            this.Room_Price.DataPropertyName = "Room_Price";
            this.Room_Price.HeaderText = "Room_Price";
            this.Room_Price.MinimumWidth = 6;
            this.Room_Price.Name = "Room_Price";
            this.Room_Price.Width = 125;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 554);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database2DataSet2 database2DataSet2;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Database2DataSet2TableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database2DataSet4 database2DataSet4;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private Database2DataSet4TableAdapters.RoomsTableAdapter roomsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomFloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomBedNumDataGridViewTextBoxColumn;
        private Database2DataSet18 database2DataSet18;
        private System.Windows.Forms.BindingSource roomsBindingSource2;
        private Database2DataSet18TableAdapters.RoomsTableAdapter roomsTableAdapter2;
        private Database2DataSet19 database2DataSet19;
        private System.Windows.Forms.BindingSource roomsBindingSource3;
        private Database2DataSet19TableAdapters.RoomsTableAdapter roomsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Price;
    }
}