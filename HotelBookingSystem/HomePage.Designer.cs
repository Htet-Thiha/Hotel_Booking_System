namespace HotelBookingSystem
{
    partial class HomePage
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
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBS_DBDataSet = new HotelBookingSystem.HBS_DBDataSet();
            this.tblUserTableAdapter = new HotelBookingSystem.HBS_DBDataSetTableAdapters.tblUserTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hBS_DBDataSet1 = new HotelBookingSystem.HBS_DBDataSet1();
            this.tblRoomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRoomTypeTableAdapter = new HotelBookingSystem.HBS_DBDataSet1TableAdapters.tblRoomTypeTableAdapter();
            this.roomTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessExtraDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.extraFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.hBS_DBDataSet;
            // 
            // hBS_DBDataSet
            // 
            this.hBS_DBDataSet.DataSetName = "HBS_DBDataSet";
            this.hBS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomTypeIDDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.maxPersonDataGridViewTextBoxColumn,
            this.accessExtraDataGridViewCheckBoxColumn,
            this.extraFeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblRoomTypeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(320, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(890, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // hBS_DBDataSet1
            // 
            this.hBS_DBDataSet1.DataSetName = "HBS_DBDataSet1";
            this.hBS_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomTypeBindingSource
            // 
            this.tblRoomTypeBindingSource.DataMember = "tblRoomType";
            this.tblRoomTypeBindingSource.DataSource = this.hBS_DBDataSet1;
            // 
            // tblRoomTypeTableAdapter
            // 
            this.tblRoomTypeTableAdapter.ClearBeforeFill = true;
            // 
            // roomTypeIDDataGridViewTextBoxColumn
            // 
            this.roomTypeIDDataGridViewTextBoxColumn.DataPropertyName = "RoomTypeID";
            this.roomTypeIDDataGridViewTextBoxColumn.HeaderText = "RoomTypeID";
            this.roomTypeIDDataGridViewTextBoxColumn.Name = "roomTypeIDDataGridViewTextBoxColumn";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // maxPersonDataGridViewTextBoxColumn
            // 
            this.maxPersonDataGridViewTextBoxColumn.DataPropertyName = "MaxPerson";
            this.maxPersonDataGridViewTextBoxColumn.HeaderText = "MaxPerson";
            this.maxPersonDataGridViewTextBoxColumn.Name = "maxPersonDataGridViewTextBoxColumn";
            // 
            // accessExtraDataGridViewCheckBoxColumn
            // 
            this.accessExtraDataGridViewCheckBoxColumn.DataPropertyName = "AccessExtra";
            this.accessExtraDataGridViewCheckBoxColumn.HeaderText = "AccessExtra";
            this.accessExtraDataGridViewCheckBoxColumn.Name = "accessExtraDataGridViewCheckBoxColumn";
            // 
            // extraFeeDataGridViewTextBoxColumn
            // 
            this.extraFeeDataGridViewTextBoxColumn.DataPropertyName = "ExtraFee";
            this.extraFeeDataGridViewTextBoxColumn.HeaderText = "ExtraFee";
            this.extraFeeDataGridViewTextBoxColumn.Name = "extraFeeDataGridViewTextBoxColumn";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 809);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HBS_DBDataSet hBS_DBDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private HBS_DBDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HBS_DBDataSet1 hBS_DBDataSet1;
        private System.Windows.Forms.BindingSource tblRoomTypeBindingSource;
        private HBS_DBDataSet1TableAdapters.tblRoomTypeTableAdapter tblRoomTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn accessExtraDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraFeeDataGridViewTextBoxColumn;
    }
}