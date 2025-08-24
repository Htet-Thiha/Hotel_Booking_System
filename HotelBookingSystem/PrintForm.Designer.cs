namespace HotelBookingSystem
{
    partial class PrintForm
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
            this.bookingDataGrid = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalguestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBS_DBDataSet3 = new HotelBookingSystem.HBS_DBDataSet3();
            this.bookingPrintBtn = new System.Windows.Forms.Button();
            this.bookingMailBtn = new System.Windows.Forms.Button();
            this.bookingExportBtn = new System.Windows.Forms.Button();
            this.tblBookingTableAdapter = new HotelBookingSystem.HBS_DBDataSet3TableAdapters.tblBookingTableAdapter();
            this.roomTypeExportBtn = new System.Windows.Forms.Button();
            this.roomTypeMailBtn = new System.Windows.Forms.Button();
            this.roomTypePrintBtn = new System.Windows.Forms.Button();
            this.roomTypeDataGrid = new System.Windows.Forms.DataGridView();
            this.roomtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepernightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraavailableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.extrafeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionavailableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sessionfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRoomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerExportBtn = new System.Windows.Forms.Button();
            this.customerMailBtn = new System.Windows.Forms.Button();
            this.customerPrintBtn = new System.Windows.Forms.Button();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRoomTypeTableAdapter = new HotelBookingSystem.HBS_DBDataSet3TableAdapters.tblRoomTypeTableAdapter();
            this.tblCustomerTableAdapter = new HotelBookingSystem.HBS_DBDataSet3TableAdapters.tblCustomerTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.hBS_DBDataSet2 = new HotelBookingSystem.HBS_DBDataSet2();
            this.hBSDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter1 = new HotelBookingSystem.HBS_DBDataSet2TableAdapters.tblCustomerTableAdapter();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrctypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBSDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingDataGrid
            // 
            this.bookingDataGrid.AllowUserToAddRows = false;
            this.bookingDataGrid.AllowUserToDeleteRows = false;
            this.bookingDataGrid.AutoGenerateColumns = false;
            this.bookingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.bookingdateDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.totalguestDataGridViewTextBoxColumn,
            this.specialrequestDataGridViewTextBoxColumn,
            this.depositamountDataGridViewTextBoxColumn});
            this.bookingDataGrid.DataSource = this.tblBookingBindingSource;
            this.bookingDataGrid.Location = new System.Drawing.Point(54, 93);
            this.bookingDataGrid.Name = "bookingDataGrid";
            this.bookingDataGrid.ReadOnly = true;
            this.bookingDataGrid.RowTemplate.Height = 33;
            this.bookingDataGrid.Size = new System.Drawing.Size(1028, 278);
            this.bookingDataGrid.TabIndex = 1;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingdateDataGridViewTextBoxColumn
            // 
            this.bookingdateDataGridViewTextBoxColumn.DataPropertyName = "booking_date";
            this.bookingdateDataGridViewTextBoxColumn.HeaderText = "booking_date";
            this.bookingdateDataGridViewTextBoxColumn.Name = "bookingdateDataGridViewTextBoxColumn";
            this.bookingdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalguestDataGridViewTextBoxColumn
            // 
            this.totalguestDataGridViewTextBoxColumn.DataPropertyName = "total_guest";
            this.totalguestDataGridViewTextBoxColumn.HeaderText = "total_guest";
            this.totalguestDataGridViewTextBoxColumn.Name = "totalguestDataGridViewTextBoxColumn";
            this.totalguestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialrequestDataGridViewTextBoxColumn
            // 
            this.specialrequestDataGridViewTextBoxColumn.DataPropertyName = "special_request";
            this.specialrequestDataGridViewTextBoxColumn.HeaderText = "special_request";
            this.specialrequestDataGridViewTextBoxColumn.Name = "specialrequestDataGridViewTextBoxColumn";
            this.specialrequestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depositamountDataGridViewTextBoxColumn
            // 
            this.depositamountDataGridViewTextBoxColumn.DataPropertyName = "deposit_amount";
            this.depositamountDataGridViewTextBoxColumn.HeaderText = "deposit_amount";
            this.depositamountDataGridViewTextBoxColumn.Name = "depositamountDataGridViewTextBoxColumn";
            this.depositamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblBookingBindingSource
            // 
            this.tblBookingBindingSource.DataMember = "tblBooking";
            this.tblBookingBindingSource.DataSource = this.hBS_DBDataSet3;
            // 
            // hBS_DBDataSet3
            // 
            this.hBS_DBDataSet3.DataSetName = "HBS_DBDataSet3";
            this.hBS_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingPrintBtn
            // 
            this.bookingPrintBtn.BackColor = System.Drawing.Color.LightBlue;
            this.bookingPrintBtn.Location = new System.Drawing.Point(1120, 304);
            this.bookingPrintBtn.Name = "bookingPrintBtn";
            this.bookingPrintBtn.Size = new System.Drawing.Size(133, 67);
            this.bookingPrintBtn.TabIndex = 2;
            this.bookingPrintBtn.Text = "Print";
            this.bookingPrintBtn.UseVisualStyleBackColor = false;
            this.bookingPrintBtn.Click += new System.EventHandler(this.bookingPrintBtn_Click);
            // 
            // bookingMailBtn
            // 
            this.bookingMailBtn.BackColor = System.Drawing.Color.LightBlue;
            this.bookingMailBtn.Enabled = false;
            this.bookingMailBtn.Location = new System.Drawing.Point(1268, 304);
            this.bookingMailBtn.Name = "bookingMailBtn";
            this.bookingMailBtn.Size = new System.Drawing.Size(133, 67);
            this.bookingMailBtn.TabIndex = 3;
            this.bookingMailBtn.Text = "Mail";
            this.bookingMailBtn.UseVisualStyleBackColor = false;
            this.bookingMailBtn.Click += new System.EventHandler(this.bookingMailBtn_Click);
            // 
            // bookingExportBtn
            // 
            this.bookingExportBtn.BackColor = System.Drawing.Color.LightBlue;
            this.bookingExportBtn.Location = new System.Drawing.Point(1418, 304);
            this.bookingExportBtn.Name = "bookingExportBtn";
            this.bookingExportBtn.Size = new System.Drawing.Size(133, 67);
            this.bookingExportBtn.TabIndex = 4;
            this.bookingExportBtn.Text = "Export";
            this.bookingExportBtn.UseVisualStyleBackColor = false;
            this.bookingExportBtn.Click += new System.EventHandler(this.bookingExportBtn_Click);
            // 
            // tblBookingTableAdapter
            // 
            this.tblBookingTableAdapter.ClearBeforeFill = true;
            // 
            // roomTypeExportBtn
            // 
            this.roomTypeExportBtn.BackColor = System.Drawing.Color.LightBlue;
            this.roomTypeExportBtn.Location = new System.Drawing.Point(1418, 717);
            this.roomTypeExportBtn.Name = "roomTypeExportBtn";
            this.roomTypeExportBtn.Size = new System.Drawing.Size(133, 67);
            this.roomTypeExportBtn.TabIndex = 8;
            this.roomTypeExportBtn.Text = "Export";
            this.roomTypeExportBtn.UseVisualStyleBackColor = false;
            this.roomTypeExportBtn.Click += new System.EventHandler(this.roomTypeExportBtn_Click);
            // 
            // roomTypeMailBtn
            // 
            this.roomTypeMailBtn.BackColor = System.Drawing.Color.LightBlue;
            this.roomTypeMailBtn.Location = new System.Drawing.Point(1268, 717);
            this.roomTypeMailBtn.Name = "roomTypeMailBtn";
            this.roomTypeMailBtn.Size = new System.Drawing.Size(133, 67);
            this.roomTypeMailBtn.TabIndex = 7;
            this.roomTypeMailBtn.Text = "Mail";
            this.roomTypeMailBtn.UseVisualStyleBackColor = false;
            // 
            // roomTypePrintBtn
            // 
            this.roomTypePrintBtn.BackColor = System.Drawing.Color.LightBlue;
            this.roomTypePrintBtn.Location = new System.Drawing.Point(1120, 717);
            this.roomTypePrintBtn.Name = "roomTypePrintBtn";
            this.roomTypePrintBtn.Size = new System.Drawing.Size(133, 67);
            this.roomTypePrintBtn.TabIndex = 6;
            this.roomTypePrintBtn.Text = "Print";
            this.roomTypePrintBtn.UseVisualStyleBackColor = false;
            this.roomTypePrintBtn.Click += new System.EventHandler(this.roomTypePrintBtn_Click);
            // 
            // roomTypeDataGrid
            // 
            this.roomTypeDataGrid.AllowUserToAddRows = false;
            this.roomTypeDataGrid.AllowUserToDeleteRows = false;
            this.roomTypeDataGrid.AutoGenerateColumns = false;
            this.roomTypeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTypeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomtypeIDDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.pricepernightDataGridViewTextBoxColumn,
            this.maxpersonDataGridViewTextBoxColumn,
            this.extraavailableDataGridViewCheckBoxColumn,
            this.extrafeeDataGridViewTextBoxColumn,
            this.sessionavailableDataGridViewCheckBoxColumn,
            this.sessionfeeDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn});
            this.roomTypeDataGrid.DataSource = this.tblRoomTypeBindingSource;
            this.roomTypeDataGrid.Location = new System.Drawing.Point(54, 506);
            this.roomTypeDataGrid.Name = "roomTypeDataGrid";
            this.roomTypeDataGrid.ReadOnly = true;
            this.roomTypeDataGrid.RowTemplate.Height = 33;
            this.roomTypeDataGrid.Size = new System.Drawing.Size(1028, 278);
            this.roomTypeDataGrid.TabIndex = 5;
            // 
            // roomtypeIDDataGridViewTextBoxColumn
            // 
            this.roomtypeIDDataGridViewTextBoxColumn.DataPropertyName = "room_type_ID";
            this.roomtypeIDDataGridViewTextBoxColumn.HeaderText = "room_type_ID";
            this.roomtypeIDDataGridViewTextBoxColumn.Name = "roomtypeIDDataGridViewTextBoxColumn";
            this.roomtypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "room_Type";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "room_Type";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricepernightDataGridViewTextBoxColumn
            // 
            this.pricepernightDataGridViewTextBoxColumn.DataPropertyName = "price_per_night";
            this.pricepernightDataGridViewTextBoxColumn.HeaderText = "price_per_night";
            this.pricepernightDataGridViewTextBoxColumn.Name = "pricepernightDataGridViewTextBoxColumn";
            this.pricepernightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxpersonDataGridViewTextBoxColumn
            // 
            this.maxpersonDataGridViewTextBoxColumn.DataPropertyName = "max_person";
            this.maxpersonDataGridViewTextBoxColumn.HeaderText = "max_person";
            this.maxpersonDataGridViewTextBoxColumn.Name = "maxpersonDataGridViewTextBoxColumn";
            this.maxpersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extraavailableDataGridViewCheckBoxColumn
            // 
            this.extraavailableDataGridViewCheckBoxColumn.DataPropertyName = "extra_available";
            this.extraavailableDataGridViewCheckBoxColumn.HeaderText = "extra_available";
            this.extraavailableDataGridViewCheckBoxColumn.Name = "extraavailableDataGridViewCheckBoxColumn";
            this.extraavailableDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // extrafeeDataGridViewTextBoxColumn
            // 
            this.extrafeeDataGridViewTextBoxColumn.DataPropertyName = "extra_fee";
            this.extrafeeDataGridViewTextBoxColumn.HeaderText = "extra_fee";
            this.extrafeeDataGridViewTextBoxColumn.Name = "extrafeeDataGridViewTextBoxColumn";
            this.extrafeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionavailableDataGridViewCheckBoxColumn
            // 
            this.sessionavailableDataGridViewCheckBoxColumn.DataPropertyName = "session_available";
            this.sessionavailableDataGridViewCheckBoxColumn.HeaderText = "session_available";
            this.sessionavailableDataGridViewCheckBoxColumn.Name = "sessionavailableDataGridViewCheckBoxColumn";
            this.sessionavailableDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sessionfeeDataGridViewTextBoxColumn
            // 
            this.sessionfeeDataGridViewTextBoxColumn.DataPropertyName = "session_fee";
            this.sessionfeeDataGridViewTextBoxColumn.HeaderText = "session_fee";
            this.sessionfeeDataGridViewTextBoxColumn.Name = "sessionfeeDataGridViewTextBoxColumn";
            this.sessionfeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblRoomTypeBindingSource
            // 
            this.tblRoomTypeBindingSource.DataMember = "tblRoomType";
            this.tblRoomTypeBindingSource.DataSource = this.hBS_DBDataSet3;
            // 
            // customerExportBtn
            // 
            this.customerExportBtn.BackColor = System.Drawing.Color.LightBlue;
            this.customerExportBtn.Location = new System.Drawing.Point(1418, 1114);
            this.customerExportBtn.Name = "customerExportBtn";
            this.customerExportBtn.Size = new System.Drawing.Size(133, 67);
            this.customerExportBtn.TabIndex = 12;
            this.customerExportBtn.Text = "Export";
            this.customerExportBtn.UseVisualStyleBackColor = false;
            this.customerExportBtn.Click += new System.EventHandler(this.customerExportBtn_Click);
            // 
            // customerMailBtn
            // 
            this.customerMailBtn.BackColor = System.Drawing.Color.LightBlue;
            this.customerMailBtn.Enabled = false;
            this.customerMailBtn.Location = new System.Drawing.Point(1268, 1114);
            this.customerMailBtn.Name = "customerMailBtn";
            this.customerMailBtn.Size = new System.Drawing.Size(133, 67);
            this.customerMailBtn.TabIndex = 11;
            this.customerMailBtn.Text = "Mail";
            this.customerMailBtn.UseVisualStyleBackColor = false;
            // 
            // customerPrintBtn
            // 
            this.customerPrintBtn.BackColor = System.Drawing.Color.LightBlue;
            this.customerPrintBtn.Location = new System.Drawing.Point(1120, 1114);
            this.customerPrintBtn.Name = "customerPrintBtn";
            this.customerPrintBtn.Size = new System.Drawing.Size(133, 67);
            this.customerPrintBtn.TabIndex = 10;
            this.customerPrintBtn.Text = "Print";
            this.customerPrintBtn.UseVisualStyleBackColor = false;
            this.customerPrintBtn.Click += new System.EventHandler(this.customerPrintBtn_Click);
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToAddRows = false;
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.AutoGenerateColumns = false;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.customernameDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customeremailDataGridViewTextBoxColumn,
            this.nrctypeDataGridViewTextBoxColumn,
            this.nrcnoDataGridViewTextBoxColumn});
            this.customerDataGrid.DataSource = this.tblCustomerBindingSource1;
            this.customerDataGrid.Location = new System.Drawing.Point(54, 903);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.ReadOnly = true;
            this.customerDataGrid.RowTemplate.Height = 33;
            this.customerDataGrid.Size = new System.Drawing.Size(1028, 278);
            this.customerDataGrid.TabIndex = 9;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.hBS_DBDataSet3;
            // 
            // tblRoomTypeTableAdapter
            // 
            this.tblRoomTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // hBS_DBDataSet2
            // 
            this.hBS_DBDataSet2.DataSetName = "HBS_DBDataSet2";
            this.hBS_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hBSDBDataSet2BindingSource
            // 
            this.hBSDBDataSet2BindingSource.DataSource = this.hBS_DBDataSet2;
            this.hBSDBDataSet2BindingSource.Position = 0;
            // 
            // tblCustomerBindingSource1
            // 
            this.tblCustomerBindingSource1.DataMember = "tblCustomer";
            this.tblCustomerBindingSource1.DataSource = this.hBSDBDataSet2BindingSource;
            // 
            // tblCustomerTableAdapter1
            // 
            this.tblCustomerTableAdapter1.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            this.customerphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeremailDataGridViewTextBoxColumn
            // 
            this.customeremailDataGridViewTextBoxColumn.DataPropertyName = "customer_email";
            this.customeremailDataGridViewTextBoxColumn.HeaderText = "customer_email";
            this.customeremailDataGridViewTextBoxColumn.Name = "customeremailDataGridViewTextBoxColumn";
            this.customeremailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrctypeDataGridViewTextBoxColumn
            // 
            this.nrctypeDataGridViewTextBoxColumn.DataPropertyName = "nrc_type";
            this.nrctypeDataGridViewTextBoxColumn.HeaderText = "nrc_type";
            this.nrctypeDataGridViewTextBoxColumn.Name = "nrctypeDataGridViewTextBoxColumn";
            this.nrctypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrcnoDataGridViewTextBoxColumn
            // 
            this.nrcnoDataGridViewTextBoxColumn.DataPropertyName = "nrc_no";
            this.nrcnoDataGridViewTextBoxColumn.HeaderText = "nrc_no";
            this.nrcnoDataGridViewTextBoxColumn.Name = "nrcnoDataGridViewTextBoxColumn";
            this.nrcnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1193);
            this.Controls.Add(this.customerExportBtn);
            this.Controls.Add(this.customerMailBtn);
            this.Controls.Add(this.customerPrintBtn);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.roomTypeExportBtn);
            this.Controls.Add(this.roomTypeMailBtn);
            this.Controls.Add(this.roomTypePrintBtn);
            this.Controls.Add(this.roomTypeDataGrid);
            this.Controls.Add(this.bookingExportBtn);
            this.Controls.Add(this.bookingMailBtn);
            this.Controls.Add(this.bookingPrintBtn);
            this.Controls.Add(this.bookingDataGrid);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBSDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingDataGrid;
        private System.Windows.Forms.Button bookingPrintBtn;
        private System.Windows.Forms.Button bookingMailBtn;
        private System.Windows.Forms.Button bookingExportBtn;
        private HBS_DBDataSet3 hBS_DBDataSet3;
        private System.Windows.Forms.BindingSource tblBookingBindingSource;
        private HBS_DBDataSet3TableAdapters.tblBookingTableAdapter tblBookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalguestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialrequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button roomTypeExportBtn;
        private System.Windows.Forms.Button roomTypeMailBtn;
        private System.Windows.Forms.Button roomTypePrintBtn;
        private System.Windows.Forms.DataGridView roomTypeDataGrid;
        private System.Windows.Forms.Button customerExportBtn;
        private System.Windows.Forms.Button customerMailBtn;
        private System.Windows.Forms.Button customerPrintBtn;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.BindingSource tblRoomTypeBindingSource;
        private HBS_DBDataSet3TableAdapters.tblRoomTypeTableAdapter tblRoomTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepernightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn extraavailableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrafeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sessionavailableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private HBS_DBDataSet3TableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource hBSDBDataSet2BindingSource;
        private HBS_DBDataSet2 hBS_DBDataSet2;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource1;
        private HBS_DBDataSet2TableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrctypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcnoDataGridViewTextBoxColumn;
    }
}