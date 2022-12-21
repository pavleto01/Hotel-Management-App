namespace HotelProject
{
    partial class Form5
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
            this.database2DataSet = new HotelProject.Database2DataSet();
            this.database2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEGNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet1 = new HotelProject.Database2DataSet1();
            this.database2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new HotelProject.Database2DataSet1TableAdapters.ClientsTableAdapter();
            this.database2DataSet17 = new HotelProject.Database2DataSet17();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter1 = new HotelProject.Database2DataSet17TableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSetBindingSource
            // 
            this.database2DataSetBindingSource.DataSource = this.database2DataSet;
            this.database2DataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientEGNDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientAddressDataGridViewTextBoxColumn,
            this.clientIdCardDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(725, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientEGNDataGridViewTextBoxColumn
            // 
            this.clientEGNDataGridViewTextBoxColumn.DataPropertyName = "Client_EGN";
            this.clientEGNDataGridViewTextBoxColumn.HeaderText = "Client_EGN";
            this.clientEGNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientEGNDataGridViewTextBoxColumn.Name = "clientEGNDataGridViewTextBoxColumn";
            this.clientEGNDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientAddressDataGridViewTextBoxColumn
            // 
            this.clientAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Address";
            this.clientAddressDataGridViewTextBoxColumn.HeaderText = "Client_Address";
            this.clientAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientAddressDataGridViewTextBoxColumn.Name = "clientAddressDataGridViewTextBoxColumn";
            this.clientAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIdCardDataGridViewTextBoxColumn
            // 
            this.clientIdCardDataGridViewTextBoxColumn.DataPropertyName = "Client_IdCard";
            this.clientIdCardDataGridViewTextBoxColumn.HeaderText = "Client_IdCard";
            this.clientIdCardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIdCardDataGridViewTextBoxColumn.Name = "clientIdCardDataGridViewTextBoxColumn";
            this.clientIdCardDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.database2DataSet1;
            // 
            // database2DataSet1
            // 
            this.database2DataSet1.DataSetName = "Database2DataSet1";
            this.database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSetBindingSource1
            // 
            this.database2DataSetBindingSource1.DataSource = this.database2DataSet;
            this.database2DataSetBindingSource1.Position = 0;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // database2DataSet17
            // 
            this.database2DataSet17.DataSetName = "Database2DataSet17";
            this.database2DataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.database2DataSet17;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 530);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource database2DataSetBindingSource;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database2DataSetBindingSource1;
        private Database2DataSet1 database2DataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Database2DataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEGNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdCardDataGridViewTextBoxColumn;
        private Database2DataSet17 database2DataSet17;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private Database2DataSet17TableAdapters.ClientsTableAdapter clientsTableAdapter1;
    }
}