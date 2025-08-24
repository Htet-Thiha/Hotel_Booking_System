namespace HotelBookingSystem
{
    partial class BookingAndBookingDetail
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
            this.booking_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_guest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special_request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBSDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBS_DBDataSet3 = new HotelBookingSystem.HBS_DBDataSet3();
            this.bookingDetailDataGrid = new System.Windows.Forms.DataGridView();
            this.booking_detail_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_ID_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra_guest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra_guest_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_in_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_out_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBookingDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBookingTableAdapter = new HotelBookingSystem.HBS_DBDataSet3TableAdapters.tblBookingTableAdapter();
            this.tblBookingDetailTableAdapter = new HotelBookingSystem.HBS_DBDataSet3TableAdapters.tblBookingDetailTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.totalGuestBox = new System.Windows.Forms.TextBox();
            this.specialRequestBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingUpdateBtn = new System.Windows.Forms.Button();
            this.bookingDeleteBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.guestNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkOutDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.checkInDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bookingDetailDeleteBtn = new System.Windows.Forms.Button();
            this.bookingDetailUpdateBtn = new System.Windows.Forms.Button();
            this.bookingSearchBox = new System.Windows.Forms.TextBox();
            this.bookingSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBSDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingDataGrid
            // 
            this.bookingDataGrid.AllowUserToAddRows = false;
            this.bookingDataGrid.AllowUserToDeleteRows = false;
            this.bookingDataGrid.AutoGenerateColumns = false;
            this.bookingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booking_ID,
            this.customer_ID,
            this.status,
            this.booking_date,
            this.total_price,
            this.total_guest,
            this.special_request,
            this.deposit_amount});
            this.bookingDataGrid.DataSource = this.tblBookingBindingSource;
            this.bookingDataGrid.Location = new System.Drawing.Point(32, 211);
            this.bookingDataGrid.Name = "bookingDataGrid";
            this.bookingDataGrid.ReadOnly = true;
            this.bookingDataGrid.RowTemplate.Height = 33;
            this.bookingDataGrid.Size = new System.Drawing.Size(746, 470);
            this.bookingDataGrid.TabIndex = 0;
            this.bookingDataGrid.SelectionChanged += new System.EventHandler(this.bookingDataGrid_SelectionChanged);
            // 
            // booking_ID
            // 
            this.booking_ID.DataPropertyName = "booking_ID";
            this.booking_ID.HeaderText = "booking_ID";
            this.booking_ID.Name = "booking_ID";
            this.booking_ID.ReadOnly = true;
            // 
            // customer_ID
            // 
            this.customer_ID.DataPropertyName = "customer_ID";
            this.customer_ID.HeaderText = "customer_ID";
            this.customer_ID.Name = "customer_ID";
            this.customer_ID.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // booking_date
            // 
            this.booking_date.DataPropertyName = "booking_date";
            this.booking_date.HeaderText = "booking_date";
            this.booking_date.Name = "booking_date";
            this.booking_date.ReadOnly = true;
            // 
            // total_price
            // 
            this.total_price.DataPropertyName = "total_price";
            this.total_price.HeaderText = "total_price";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            // 
            // total_guest
            // 
            this.total_guest.DataPropertyName = "total_guest";
            this.total_guest.HeaderText = "total_guest";
            this.total_guest.Name = "total_guest";
            this.total_guest.ReadOnly = true;
            // 
            // special_request
            // 
            this.special_request.DataPropertyName = "special_request";
            this.special_request.HeaderText = "special_request";
            this.special_request.Name = "special_request";
            this.special_request.ReadOnly = true;
            // 
            // deposit_amount
            // 
            this.deposit_amount.DataPropertyName = "deposit_amount";
            this.deposit_amount.HeaderText = "deposit_amount";
            this.deposit_amount.Name = "deposit_amount";
            this.deposit_amount.ReadOnly = true;
            // 
            // tblBookingBindingSource
            // 
            this.tblBookingBindingSource.DataMember = "tblBooking";
            this.tblBookingBindingSource.DataSource = this.hBSDBDataSet3BindingSource;
            // 
            // hBSDBDataSet3BindingSource
            // 
            this.hBSDBDataSet3BindingSource.DataSource = this.hBS_DBDataSet3;
            this.hBSDBDataSet3BindingSource.Position = 0;
            // 
            // hBS_DBDataSet3
            // 
            this.hBS_DBDataSet3.DataSetName = "HBS_DBDataSet3";
            this.hBS_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingDetailDataGrid
            // 
            this.bookingDetailDataGrid.AllowUserToAddRows = false;
            this.bookingDetailDataGrid.AllowUserToDeleteRows = false;
            this.bookingDetailDataGrid.AutoGenerateColumns = false;
            this.bookingDetailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDetailDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booking_detail_ID,
            this.booking_ID_Detail,
            this.room_ID,
            this.extra_guest,
            this.extra_guest_price,
            this.room_price,
            this.check_in_date,
            this.check_out_date});
            this.bookingDetailDataGrid.DataSource = this.tblBookingDetailBindingSource;
            this.bookingDetailDataGrid.Location = new System.Drawing.Point(822, 211);
            this.bookingDetailDataGrid.Name = "bookingDetailDataGrid";
            this.bookingDetailDataGrid.ReadOnly = true;
            this.bookingDetailDataGrid.RowTemplate.Height = 33;
            this.bookingDetailDataGrid.Size = new System.Drawing.Size(854, 470);
            this.bookingDetailDataGrid.TabIndex = 1;
            this.bookingDetailDataGrid.SelectionChanged += new System.EventHandler(this.bookingDetailDataGrid_SelectionChanged);
            // 
            // booking_detail_ID
            // 
            this.booking_detail_ID.DataPropertyName = "booking_detail_ID";
            this.booking_detail_ID.HeaderText = "booking_detail_ID";
            this.booking_detail_ID.Name = "booking_detail_ID";
            this.booking_detail_ID.ReadOnly = true;
            // 
            // booking_ID_Detail
            // 
            this.booking_ID_Detail.DataPropertyName = "booking_ID";
            this.booking_ID_Detail.HeaderText = "booking_ID";
            this.booking_ID_Detail.Name = "booking_ID_Detail";
            this.booking_ID_Detail.ReadOnly = true;
            // 
            // room_ID
            // 
            this.room_ID.DataPropertyName = "room_ID";
            this.room_ID.HeaderText = "room_ID";
            this.room_ID.Name = "room_ID";
            this.room_ID.ReadOnly = true;
            // 
            // extra_guest
            // 
            this.extra_guest.DataPropertyName = "extra_guest";
            this.extra_guest.HeaderText = "extra_guest";
            this.extra_guest.Name = "extra_guest";
            this.extra_guest.ReadOnly = true;
            // 
            // extra_guest_price
            // 
            this.extra_guest_price.DataPropertyName = "extra_guest_price";
            this.extra_guest_price.HeaderText = "extra_guest_price";
            this.extra_guest_price.Name = "extra_guest_price";
            this.extra_guest_price.ReadOnly = true;
            // 
            // room_price
            // 
            this.room_price.DataPropertyName = "room_price";
            this.room_price.HeaderText = "room_price";
            this.room_price.Name = "room_price";
            this.room_price.ReadOnly = true;
            // 
            // check_in_date
            // 
            this.check_in_date.DataPropertyName = "check_in_date";
            this.check_in_date.HeaderText = "check_in_date";
            this.check_in_date.Name = "check_in_date";
            this.check_in_date.ReadOnly = true;
            // 
            // check_out_date
            // 
            this.check_out_date.DataPropertyName = "check_out_date";
            this.check_out_date.HeaderText = "check_out_date";
            this.check_out_date.Name = "check_out_date";
            this.check_out_date.ReadOnly = true;
            // 
            // tblBookingDetailBindingSource
            // 
            this.tblBookingDetailBindingSource.DataMember = "tblBookingDetail";
            this.tblBookingDetailBindingSource.DataSource = this.hBSDBDataSet3BindingSource;
            // 
            // tblBookingTableAdapter
            // 
            this.tblBookingTableAdapter.ClearBeforeFill = true;
            // 
            // tblBookingDetailTableAdapter
            // 
            this.tblBookingDetailTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 717);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Guest";
            // 
            // totalGuestBox
            // 
            this.totalGuestBox.Location = new System.Drawing.Point(240, 714);
            this.totalGuestBox.Name = "totalGuestBox";
            this.totalGuestBox.Size = new System.Drawing.Size(228, 31);
            this.totalGuestBox.TabIndex = 3;
            // 
            // specialRequestBox
            // 
            this.specialRequestBox.Location = new System.Drawing.Point(240, 764);
            this.specialRequestBox.Multiline = true;
            this.specialRequestBox.Name = "specialRequestBox";
            this.specialRequestBox.Size = new System.Drawing.Size(228, 81);
            this.specialRequestBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 767);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Special Request";
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(240, 872);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(228, 31);
            this.depositBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 875);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deposit Amount";
            // 
            // bookingUpdateBtn
            // 
            this.bookingUpdateBtn.BackColor = System.Drawing.Color.LightBlue;
            this.bookingUpdateBtn.Location = new System.Drawing.Point(44, 939);
            this.bookingUpdateBtn.Name = "bookingUpdateBtn";
            this.bookingUpdateBtn.Size = new System.Drawing.Size(111, 49);
            this.bookingUpdateBtn.TabIndex = 8;
            this.bookingUpdateBtn.Text = "Update";
            this.bookingUpdateBtn.UseVisualStyleBackColor = false;
            this.bookingUpdateBtn.Click += new System.EventHandler(this.booingUpdateBtn_Click);
            // 
            // bookingDeleteBtn
            // 
            this.bookingDeleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.bookingDeleteBtn.Location = new System.Drawing.Point(187, 939);
            this.bookingDeleteBtn.Name = "bookingDeleteBtn";
            this.bookingDeleteBtn.Size = new System.Drawing.Size(111, 49);
            this.bookingDeleteBtn.TabIndex = 9;
            this.bookingDeleteBtn.Text = "Delete";
            this.bookingDeleteBtn.UseVisualStyleBackColor = false;
            this.bookingDeleteBtn.Click += new System.EventHandler(this.bookingDeleteBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(822, 732);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 25);
            this.label18.TabIndex = 53;
            this.label18.Text = "Exra Guest";
            // 
            // guestNumberUpDown
            // 
            this.guestNumberUpDown.Location = new System.Drawing.Point(1036, 732);
            this.guestNumberUpDown.Name = "guestNumberUpDown";
            this.guestNumberUpDown.Size = new System.Drawing.Size(200, 31);
            this.guestNumberUpDown.TabIndex = 52;
            // 
            // checkOutDate
            // 
            this.checkOutDate.Location = new System.Drawing.Point(1036, 832);
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.Size = new System.Drawing.Size(200, 31);
            this.checkOutDate.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 838);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Check Out Date";
            // 
            // checkInDate
            // 
            this.checkInDate.Location = new System.Drawing.Point(1036, 795);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(200, 31);
            this.checkInDate.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(822, 801);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Check In Date";
            // 
            // bookingDetailDeleteBtn
            // 
            this.bookingDetailDeleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.bookingDetailDeleteBtn.Location = new System.Drawing.Point(977, 939);
            this.bookingDetailDeleteBtn.Name = "bookingDetailDeleteBtn";
            this.bookingDetailDeleteBtn.Size = new System.Drawing.Size(111, 49);
            this.bookingDetailDeleteBtn.TabIndex = 59;
            this.bookingDetailDeleteBtn.Text = "Delete";
            this.bookingDetailDeleteBtn.UseVisualStyleBackColor = false;
            this.bookingDetailDeleteBtn.Click += new System.EventHandler(this.bookingDetailDeleteBtn_Click);
            // 
            // bookingDetailUpdateBtn
            // 
            this.bookingDetailUpdateBtn.BackColor = System.Drawing.Color.LightBlue;
            this.bookingDetailUpdateBtn.Location = new System.Drawing.Point(827, 939);
            this.bookingDetailUpdateBtn.Name = "bookingDetailUpdateBtn";
            this.bookingDetailUpdateBtn.Size = new System.Drawing.Size(111, 49);
            this.bookingDetailUpdateBtn.TabIndex = 58;
            this.bookingDetailUpdateBtn.Text = "Update";
            this.bookingDetailUpdateBtn.UseVisualStyleBackColor = false;
            this.bookingDetailUpdateBtn.Click += new System.EventHandler(this.bookingDetailUpdateBtn_Click);
            // 
            // bookingSearchBox
            // 
            this.bookingSearchBox.Location = new System.Drawing.Point(32, 141);
            this.bookingSearchBox.Name = "bookingSearchBox";
            this.bookingSearchBox.Size = new System.Drawing.Size(228, 31);
            this.bookingSearchBox.TabIndex = 60;
            // 
            // bookingSearchBtn
            // 
            this.bookingSearchBtn.BackColor = System.Drawing.Color.LightBlue;
            this.bookingSearchBtn.Location = new System.Drawing.Point(300, 132);
            this.bookingSearchBtn.Name = "bookingSearchBtn";
            this.bookingSearchBtn.Size = new System.Drawing.Size(168, 49);
            this.bookingSearchBtn.TabIndex = 61;
            this.bookingSearchBtn.Text = "Search";
            this.bookingSearchBtn.UseVisualStyleBackColor = false;
            this.bookingSearchBtn.Click += new System.EventHandler(this.bookingSearchBtn_Click);
            // 
            // BookingAndBookingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 1087);
            this.Controls.Add(this.bookingSearchBtn);
            this.Controls.Add(this.bookingSearchBox);
            this.Controls.Add(this.bookingDetailDeleteBtn);
            this.Controls.Add(this.bookingDetailUpdateBtn);
            this.Controls.Add(this.checkOutDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkInDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.guestNumberUpDown);
            this.Controls.Add(this.bookingDeleteBtn);
            this.Controls.Add(this.bookingUpdateBtn);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.specialRequestBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalGuestBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingDetailDataGrid);
            this.Controls.Add(this.bookingDataGrid);
            this.Name = "BookingAndBookingDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingAndBookingDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookingAndBookingDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBSDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingDataGrid;
        private System.Windows.Forms.BindingSource hBSDBDataSet3BindingSource;
        private HBS_DBDataSet3 hBS_DBDataSet3;
        private System.Windows.Forms.DataGridView bookingDetailDataGrid;
        private System.Windows.Forms.BindingSource tblBookingBindingSource;
        private HBS_DBDataSet3TableAdapters.tblBookingTableAdapter tblBookingTableAdapter;
        private System.Windows.Forms.BindingSource tblBookingDetailBindingSource;
        private HBS_DBDataSet3TableAdapters.tblBookingDetailTableAdapter tblBookingDetailTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalGuestBox;
        private System.Windows.Forms.TextBox specialRequestBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bookingUpdateBtn;
        private System.Windows.Forms.Button bookingDeleteBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown guestNumberUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_guest;
        private System.Windows.Forms.DataGridViewTextBoxColumn special_request;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_detail_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_ID_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_guest;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_guest_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn check_in_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn check_out_date;
        private System.Windows.Forms.DateTimePicker checkOutDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker checkInDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bookingDetailDeleteBtn;
        private System.Windows.Forms.Button bookingDetailUpdateBtn;
        private System.Windows.Forms.TextBox bookingSearchBox;
        private System.Windows.Forms.Button bookingSearchBtn;
    }
}