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
            this.tblBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBSDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBS_DBDataSet3 = new HotelBookingSystem.HBS_DBDataSet3();
            this.tblBookingTableAdapter = new HotelBookingSystem.HBS_DBDataSet3TableAdapters.tblBookingTableAdapter();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.chechOutBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.currentGuest = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.availableRooms = new System.Windows.Forms.Label();
            this.bookingGrid = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalguestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dueAmountBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.totalPriceBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.specialRequestBox = new System.Windows.Forms.TextBox();
            this.guestBox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerPhoneBox = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBSDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGrid)).BeginInit();
            this.SuspendLayout();
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
            // tblBookingTableAdapter
            // 
            this.tblBookingTableAdapter.ClearBeforeFill = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(1270, 1015);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(322, 87);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // chechOutBtn
            // 
            this.chechOutBtn.BackColor = System.Drawing.Color.LightBlue;
            this.chechOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chechOutBtn.Location = new System.Drawing.Point(906, 1015);
            this.chechOutBtn.Name = "chechOutBtn";
            this.chechOutBtn.Size = new System.Drawing.Size(322, 87);
            this.chechOutBtn.TabIndex = 30;
            this.chechOutBtn.Text = "Check Out";
            this.chechOutBtn.UseVisualStyleBackColor = false;
            this.chechOutBtn.Click += new System.EventHandler(this.chechOutBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 582);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(339, 55);
            this.label8.TabIndex = 29;
            this.label8.Text = "Current Guest";
            // 
            // currentGuest
            // 
            this.currentGuest.AutoSize = true;
            this.currentGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGuest.Location = new System.Drawing.Point(223, 670);
            this.currentGuest.Name = "currentGuest";
            this.currentGuest.Size = new System.Drawing.Size(52, 55);
            this.currentGuest.TabIndex = 28;
            this.currentGuest.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 55);
            this.label7.TabIndex = 27;
            this.label7.Text = "Available Room";
            // 
            // availableRooms
            // 
            this.availableRooms.AutoSize = true;
            this.availableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableRooms.Location = new System.Drawing.Point(223, 453);
            this.availableRooms.Name = "availableRooms";
            this.availableRooms.Size = new System.Drawing.Size(52, 55);
            this.availableRooms.TabIndex = 26;
            this.availableRooms.Text = "0";
            // 
            // bookingGrid
            // 
            this.bookingGrid.AllowUserToAddRows = false;
            this.bookingGrid.AutoGenerateColumns = false;
            this.bookingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.bookingdateDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.totalguestDataGridViewTextBoxColumn,
            this.specialrequestDataGridViewTextBoxColumn,
            this.depositamountDataGridViewTextBoxColumn});
            this.bookingGrid.DataSource = this.tblBookingBindingSource;
            this.bookingGrid.Location = new System.Drawing.Point(546, 281);
            this.bookingGrid.Name = "bookingGrid";
            this.bookingGrid.RowTemplate.Height = 33;
            this.bookingGrid.Size = new System.Drawing.Size(1044, 354);
            this.bookingGrid.TabIndex = 24;
            this.bookingGrid.SelectionChanged += new System.EventHandler(this.bookingGrid_SelectionChanged);
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // bookingdateDataGridViewTextBoxColumn
            // 
            this.bookingdateDataGridViewTextBoxColumn.DataPropertyName = "booking_date";
            this.bookingdateDataGridViewTextBoxColumn.HeaderText = "booking_date";
            this.bookingdateDataGridViewTextBoxColumn.Name = "bookingdateDataGridViewTextBoxColumn";
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            // 
            // totalguestDataGridViewTextBoxColumn
            // 
            this.totalguestDataGridViewTextBoxColumn.DataPropertyName = "total_guest";
            this.totalguestDataGridViewTextBoxColumn.HeaderText = "total_guest";
            this.totalguestDataGridViewTextBoxColumn.Name = "totalguestDataGridViewTextBoxColumn";
            // 
            // specialrequestDataGridViewTextBoxColumn
            // 
            this.specialrequestDataGridViewTextBoxColumn.DataPropertyName = "special_request";
            this.specialrequestDataGridViewTextBoxColumn.HeaderText = "special_request";
            this.specialrequestDataGridViewTextBoxColumn.Name = "specialrequestDataGridViewTextBoxColumn";
            // 
            // depositamountDataGridViewTextBoxColumn
            // 
            this.depositamountDataGridViewTextBoxColumn.DataPropertyName = "deposit_amount";
            this.depositamountDataGridViewTextBoxColumn.HeaderText = "deposit_amount";
            this.depositamountDataGridViewTextBoxColumn.Name = "depositamountDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(548, 1015);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 87);
            this.button2.TabIndex = 23;
            this.button2.Text = "Check In";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.chechInBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1170, 821);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = "Amount Due";
            // 
            // dueAmountBox
            // 
            this.dueAmountBox.Location = new System.Drawing.Point(1376, 818);
            this.dueAmountBox.Name = "dueAmountBox";
            this.dueAmountBox.ReadOnly = true;
            this.dueAmountBox.Size = new System.Drawing.Size(180, 31);
            this.dueAmountBox.TabIndex = 21;
            this.dueAmountBox.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1170, 781);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "Deposit Amount";
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(1376, 778);
            this.depositBox.Name = "depositBox";
            this.depositBox.ReadOnly = true;
            this.depositBox.Size = new System.Drawing.Size(180, 31);
            this.depositBox.TabIndex = 19;
            this.depositBox.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1170, 744);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Price";
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.Location = new System.Drawing.Point(1376, 741);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.ReadOnly = true;
            this.totalPriceBox.Size = new System.Drawing.Size(180, 31);
            this.totalPriceBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 886);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Special Request";
            // 
            // specialRequestBox
            // 
            this.specialRequestBox.Location = new System.Drawing.Point(754, 883);
            this.specialRequestBox.Multiline = true;
            this.specialRequestBox.Name = "specialRequestBox";
            this.specialRequestBox.ReadOnly = true;
            this.specialRequestBox.Size = new System.Drawing.Size(180, 89);
            this.specialRequestBox.TabIndex = 15;
            // 
            // guestBox
            // 
            this.guestBox.AutoSize = true;
            this.guestBox.Location = new System.Drawing.Point(749, 838);
            this.guestBox.Name = "guestBox";
            this.guestBox.Size = new System.Drawing.Size(24, 25);
            this.guestBox.TabIndex = 14;
            this.guestBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 838);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Guests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 784);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 747);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Customer Name";
            // 
            // customerPhoneBox
            // 
            this.customerPhoneBox.Location = new System.Drawing.Point(754, 781);
            this.customerPhoneBox.Name = "customerPhoneBox";
            this.customerPhoneBox.ReadOnly = true;
            this.customerPhoneBox.Size = new System.Drawing.Size(180, 31);
            this.customerPhoneBox.TabIndex = 8;
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(754, 744);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.ReadOnly = true;
            this.customerNameBox.Size = new System.Drawing.Size(180, 31);
            this.customerNameBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1170, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Payment Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 670);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Booking Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Booking List";
            // 
            // bookingSearchBtn
            // 
            this.bookingSearchBtn.BackColor = System.Drawing.Color.LightBlue;
            this.bookingSearchBtn.Location = new System.Drawing.Point(844, 118);
            this.bookingSearchBtn.Name = "bookingSearchBtn";
            this.bookingSearchBtn.Size = new System.Drawing.Size(137, 53);
            this.bookingSearchBtn.TabIndex = 3;
            this.bookingSearchBtn.Text = "Search";
            this.bookingSearchBtn.UseVisualStyleBackColor = false;
            this.bookingSearchBtn.Click += new System.EventHandler(this.bookingSearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // bookingSearchBox
            // 
            this.bookingSearchBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bookingSearchBox.Location = new System.Drawing.Point(546, 118);
            this.bookingSearchBox.Multiline = true;
            this.bookingSearchBox.Name = "bookingSearchBox";
            this.bookingSearchBox.Size = new System.Drawing.Size(254, 53);
            this.bookingSearchBox.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1674, 1150);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.chechOutBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.currentGuest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.availableRooms);
            this.Controls.Add(this.bookingGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dueAmountBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.totalPriceBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.specialRequestBox);
            this.Controls.Add(this.guestBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerPhoneBox);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookingSearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingSearchBox);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBSDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookingSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bookingSearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox customerPhoneBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label guestBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox specialRequestBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox totalPriceBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dueAmountBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView bookingGrid;
        private System.Windows.Forms.BindingSource hBSDBDataSet3BindingSource;
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
        private System.Windows.Forms.Label availableRooms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label currentGuest;
        private System.Windows.Forms.Button chechOutBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}