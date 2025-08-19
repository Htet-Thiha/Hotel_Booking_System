namespace HotelBookingSystem
{
    partial class BookingForm
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
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nrcTypeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nrcNoBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkInDate = new System.Windows.Forms.DateTimePicker();
            this.checkOutDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.bookingDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.bookBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBS_DBDataSet1 = new HotelBookingSystem.HBS_DBDataSet1();
            this.roomTypeBox = new System.Windows.Forms.ComboBox();
            this.roomStatusBox = new System.Windows.Forms.ComboBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.maxGuestLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.extraPriceLabel = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.extraLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.sessionPriceLabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.guestNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblRoomTableAdapter = new HotelBookingSystem.HBS_DBDataSet1TableAdapters.tblRoomTableAdapter();
            this.takenRoomDataGrid = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.specialRequestBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.totalGuestBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.depositAmountBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenRoomDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(224, 50);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(224, 31);
            this.customerNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone number";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(224, 87);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(224, 31);
            this.phoneNumberBox.TabIndex = 2;
            this.phoneNumberBox.TextChanged += new System.EventHandler(this.phoneNumberBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(224, 124);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(224, 31);
            this.emailBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nrc type";
            // 
            // nrcTypeBox
            // 
            this.nrcTypeBox.Location = new System.Drawing.Point(224, 161);
            this.nrcTypeBox.Name = "nrcTypeBox";
            this.nrcTypeBox.Size = new System.Drawing.Size(224, 31);
            this.nrcTypeBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nrc No";
            // 
            // nrcNoBox
            // 
            this.nrcNoBox.Location = new System.Drawing.Point(224, 198);
            this.nrcNoBox.Name = "nrcNoBox";
            this.nrcNoBox.Size = new System.Drawing.Size(224, 31);
            this.nrcNoBox.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(69, 267);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 49);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(265, 267);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(117, 49);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(961, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Check In Date";
            // 
            // checkInDate
            // 
            this.checkInDate.Location = new System.Drawing.Point(1175, 607);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(200, 31);
            this.checkInDate.TabIndex = 13;
            // 
            // checkOutDate
            // 
            this.checkOutDate.Location = new System.Drawing.Point(1175, 644);
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.Size = new System.Drawing.Size(200, 31);
            this.checkOutDate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(961, 650);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Check Out Date";
            // 
            // bookingDate
            // 
            this.bookingDate.Enabled = false;
            this.bookingDate.Location = new System.Drawing.Point(248, 499);
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.Size = new System.Drawing.Size(200, 31);
            this.bookingDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Booking Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 797);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Price";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(286, 797);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(84, 25);
            this.totalPriceLabel.TabIndex = 22;
            this.totalPriceLabel.Text = "000000";
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(589, 1007);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(409, 113);
            this.bookBtn.TabIndex = 23;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Customer ID";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(267, 375);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(19, 25);
            this.customerIDLabel.TabIndex = 26;
            this.customerIDLabel.Text = "-";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(248, 536);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(229, 33);
            this.statusBox.TabIndex = 27;
            this.statusBox.Text = "status";
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AutoGenerateColumns = false;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomnoDataGridViewTextBoxColumn,
            this.roomtypeIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.roomDataGridView.DataSource = this.tblRoomBindingSource;
            this.roomDataGridView.Location = new System.Drawing.Point(638, 161);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.RowTemplate.Height = 33;
            this.roomDataGridView.Size = new System.Drawing.Size(934, 260);
            this.roomDataGridView.TabIndex = 28;
            this.roomDataGridView.SelectionChanged += new System.EventHandler(this.roomDataGridView_SelectionChanged);
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "room_ID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            // 
            // roomnoDataGridViewTextBoxColumn
            // 
            this.roomnoDataGridViewTextBoxColumn.DataPropertyName = "room_no";
            this.roomnoDataGridViewTextBoxColumn.HeaderText = "room_no";
            this.roomnoDataGridViewTextBoxColumn.Name = "roomnoDataGridViewTextBoxColumn";
            // 
            // roomtypeIDDataGridViewTextBoxColumn
            // 
            this.roomtypeIDDataGridViewTextBoxColumn.DataPropertyName = "room_type_ID";
            this.roomtypeIDDataGridViewTextBoxColumn.HeaderText = "room_type_ID";
            this.roomtypeIDDataGridViewTextBoxColumn.Name = "roomtypeIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tblRoom";
            this.tblRoomBindingSource.DataSource = this.hBS_DBDataSet1;
            // 
            // hBS_DBDataSet1
            // 
            this.hBS_DBDataSet1.DataSetName = "HBS_DBDataSet1";
            this.hBS_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.FormattingEnabled = true;
            this.roomTypeBox.Location = new System.Drawing.Point(683, 65);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(229, 33);
            this.roomTypeBox.TabIndex = 29;
            this.roomTypeBox.Text = "roomType";
            // 
            // roomStatusBox
            // 
            this.roomStatusBox.FormattingEnabled = true;
            this.roomStatusBox.Location = new System.Drawing.Point(1061, 65);
            this.roomStatusBox.Name = "roomStatusBox";
            this.roomStatusBox.Size = new System.Drawing.Size(229, 33);
            this.roomStatusBox.TabIndex = 30;
            this.roomStatusBox.Text = "status";
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(1353, 65);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(117, 49);
            this.filterBtn.TabIndex = 31;
            this.filterBtn.Text = "filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(642, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Room Type";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(780, 462);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(127, 25);
            this.roomTypeLabel.TabIndex = 33;
            this.roomTypeLabel.Text = "-    standard";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(780, 499);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(127, 25);
            this.priceLabel.TabIndex = 35;
            this.priceLabel.Text = "-    standard";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(642, 499);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 25);
            this.label15.TabIndex = 34;
            this.label15.Text = "Price";
            // 
            // maxGuestLabel
            // 
            this.maxGuestLabel.AutoSize = true;
            this.maxGuestLabel.Location = new System.Drawing.Point(780, 536);
            this.maxGuestLabel.Name = "maxGuestLabel";
            this.maxGuestLabel.Size = new System.Drawing.Size(127, 25);
            this.maxGuestLabel.TabIndex = 37;
            this.maxGuestLabel.Text = "-    standard";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(642, 536);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 25);
            this.label17.TabIndex = 36;
            this.label17.Text = "Max Guest";
            // 
            // extraPriceLabel
            // 
            this.extraPriceLabel.AutoSize = true;
            this.extraPriceLabel.Location = new System.Drawing.Point(1129, 499);
            this.extraPriceLabel.Name = "extraPriceLabel";
            this.extraPriceLabel.Size = new System.Drawing.Size(127, 25);
            this.extraPriceLabel.TabIndex = 41;
            this.extraPriceLabel.Text = "-    standard";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(991, 499);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 25);
            this.label25.TabIndex = 40;
            this.label25.Text = "Extra Price";
            // 
            // extraLabel
            // 
            this.extraLabel.AutoSize = true;
            this.extraLabel.Location = new System.Drawing.Point(1129, 462);
            this.extraLabel.Name = "extraLabel";
            this.extraLabel.Size = new System.Drawing.Size(127, 25);
            this.extraLabel.TabIndex = 39;
            this.extraLabel.Text = "-    standard";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(991, 462);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(156, 25);
            this.label23.TabIndex = 38;
            this.label23.Text = "Extra Avaliable";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(1421, 499);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(127, 25);
            this.serviceLabel.TabIndex = 49;
            this.serviceLabel.Text = "-    standard";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(1283, 499);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 25);
            this.label31.TabIndex = 48;
            this.label31.Text = "Service";
            // 
            // sessionPriceLabel
            // 
            this.sessionPriceLabel.AutoSize = true;
            this.sessionPriceLabel.Location = new System.Drawing.Point(1421, 462);
            this.sessionPriceLabel.Name = "sessionPriceLabel";
            this.sessionPriceLabel.Size = new System.Drawing.Size(127, 25);
            this.sessionPriceLabel.TabIndex = 47;
            this.sessionPriceLabel.Text = "-    standard";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(1283, 462);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(144, 25);
            this.label29.TabIndex = 46;
            this.label29.Text = "Session Price";
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Location = new System.Drawing.Point(1129, 536);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(127, 25);
            this.sessionLabel.TabIndex = 45;
            this.sessionLabel.Text = "-    standard";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(991, 536);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(183, 25);
            this.label27.TabIndex = 44;
            this.label27.Text = "Session Avaliable";
            // 
            // guestNumberUpDown
            // 
            this.guestNumberUpDown.Location = new System.Drawing.Point(814, 637);
            this.guestNumberUpDown.Name = "guestNumberUpDown";
            this.guestNumberUpDown.Size = new System.Drawing.Size(120, 31);
            this.guestNumberUpDown.TabIndex = 50;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(642, 637);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 25);
            this.label18.TabIndex = 51;
            this.label18.Text = "Exra Guest";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1489, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 49);
            this.button1.TabIndex = 52;
            this.button1.Text = "Get Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.getRoomBtn_Click);
            // 
            // tblRoomTableAdapter
            // 
            this.tblRoomTableAdapter.ClearBeforeFill = true;
            // 
            // takenRoomDataGrid
            // 
            this.takenRoomDataGrid.AllowUserToAddRows = false;
            this.takenRoomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenRoomDataGrid.Location = new System.Drawing.Point(638, 694);
            this.takenRoomDataGrid.Name = "takenRoomDataGrid";
            this.takenRoomDataGrid.RowTemplate.Height = 33;
            this.takenRoomDataGrid.Size = new System.Drawing.Size(934, 284);
            this.takenRoomDataGrid.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 625);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 25);
            this.label12.TabIndex = 57;
            this.label12.Text = "Special Request";
            // 
            // specialRequestBox
            // 
            this.specialRequestBox.Location = new System.Drawing.Point(248, 622);
            this.specialRequestBox.Multiline = true;
            this.specialRequestBox.Name = "specialRequestBox";
            this.specialRequestBox.Size = new System.Drawing.Size(224, 105);
            this.specialRequestBox.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 588);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 25);
            this.label14.TabIndex = 55;
            this.label14.Text = "Total Guest";
            // 
            // totalGuestBox
            // 
            this.totalGuestBox.Location = new System.Drawing.Point(248, 585);
            this.totalGuestBox.Name = "totalGuestBox";
            this.totalGuestBox.Size = new System.Drawing.Size(224, 31);
            this.totalGuestBox.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 747);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 25);
            this.label16.TabIndex = 59;
            this.label16.Text = "Deposit Amount";
            // 
            // depositAmountBox
            // 
            this.depositAmountBox.Location = new System.Drawing.Point(248, 744);
            this.depositAmountBox.Name = "depositAmountBox";
            this.depositAmountBox.Size = new System.Drawing.Size(224, 31);
            this.depositAmountBox.TabIndex = 58;
            this.depositAmountBox.Text = "0";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 1143);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.depositAmountBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.specialRequestBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.totalGuestBox);
            this.Controls.Add(this.takenRoomDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.guestNumberUpDown);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.sessionPriceLabel);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.sessionLabel);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.extraPriceLabel);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.extraLabel);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.maxGuestLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.roomStatusBox);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.roomDataGridView);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bookingDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkOutDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkInDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nrcNoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nrcTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameBox);
            this.Name = "BookingForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenRoomDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nrcTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nrcNoBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker checkInDate;
        private System.Windows.Forms.DateTimePicker checkOutDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker bookingDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.ComboBox roomTypeBox;
        private System.Windows.Forms.ComboBox roomStatusBox;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label maxGuestLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label extraPriceLabel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label extraLabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label sessionPriceLabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown guestNumberUpDown;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private HBS_DBDataSet1 hBS_DBDataSet1;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private HBS_DBDataSet1TableAdapters.tblRoomTableAdapter tblRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView takenRoomDataGrid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox specialRequestBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox totalGuestBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox depositAmountBox;
    }
}