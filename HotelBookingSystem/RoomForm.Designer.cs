namespace HotelBookingSystem
{
    partial class RoomForm
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
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBS_DBDataSet3 = new HotelBookingSystem.HBS_DBDataSet3();
            this.tblRoomTableAdapter = new HotelBookingSystem.HBS_DBDataSet3TableAdapters.tblRoomTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomStatusBox = new System.Windows.Forms.ComboBox();
            this.roomTypeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomTypeLbl = new System.Windows.Forms.Label();
            this.serviceLbl = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.extraPriceLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.extraAvailableLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maxPersonLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roomPriceLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RoomNoLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AutoGenerateColumns = false;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomnoDataGridViewTextBoxColumn,
            this.roomtypeIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.roomDataGridView.DataSource = this.tblRoomBindingSource;
            this.roomDataGridView.Location = new System.Drawing.Point(87, 202);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.RowTemplate.Height = 33;
            this.roomDataGridView.Size = new System.Drawing.Size(638, 686);
            this.roomDataGridView.TabIndex = 29;
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
            this.tblRoomBindingSource.DataSource = this.hBS_DBDataSet3;
            // 
            // hBS_DBDataSet3
            // 
            this.hBS_DBDataSet3.DataSetName = "HBS_DBDataSet3";
            this.hBS_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomTableAdapter
            // 
            this.tblRoomTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(946, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Room No";
            // 
            // RoomNoBox
            // 
            this.RoomNoBox.Location = new System.Drawing.Point(1136, 564);
            this.RoomNoBox.Name = "RoomNoBox";
            this.RoomNoBox.Size = new System.Drawing.Size(220, 31);
            this.RoomNoBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(946, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Status";
            // 
            // roomStatusBox
            // 
            this.roomStatusBox.FormattingEnabled = true;
            this.roomStatusBox.Location = new System.Drawing.Point(1136, 608);
            this.roomStatusBox.Name = "roomStatusBox";
            this.roomStatusBox.Size = new System.Drawing.Size(220, 33);
            this.roomStatusBox.TabIndex = 33;
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.FormattingEnabled = true;
            this.roomTypeBox.Location = new System.Drawing.Point(1136, 658);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(220, 33);
            this.roomTypeBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(946, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Room Type";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(768, 799);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 89);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Location = new System.Drawing.Point(1019, 799);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 89);
            this.button2.TabIndex = 37;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomTypeLbl);
            this.groupBox1.Controls.Add(this.serviceLbl);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.extraPriceLbl);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.extraAvailableLbl);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.maxPersonLbl);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.roomPriceLbl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RoomNoLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(792, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 274);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Detail";
            // 
            // roomTypeLbl
            // 
            this.roomTypeLbl.AutoSize = true;
            this.roomTypeLbl.Location = new System.Drawing.Point(159, 101);
            this.roomTypeLbl.Name = "roomTypeLbl";
            this.roomTypeLbl.Size = new System.Drawing.Size(19, 25);
            this.roomTypeLbl.TabIndex = 53;
            this.roomTypeLbl.Text = "-";
            // 
            // serviceLbl
            // 
            this.serviceLbl.AutoSize = true;
            this.serviceLbl.Location = new System.Drawing.Point(510, 143);
            this.serviceLbl.Name = "serviceLbl";
            this.serviceLbl.Size = new System.Drawing.Size(19, 25);
            this.serviceLbl.TabIndex = 52;
            this.serviceLbl.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(358, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 25);
            this.label17.TabIndex = 51;
            this.label17.Text = "Service";
            // 
            // extraPriceLbl
            // 
            this.extraPriceLbl.AutoSize = true;
            this.extraPriceLbl.Location = new System.Drawing.Point(510, 101);
            this.extraPriceLbl.Name = "extraPriceLbl";
            this.extraPriceLbl.Size = new System.Drawing.Size(19, 25);
            this.extraPriceLbl.TabIndex = 50;
            this.extraPriceLbl.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 25);
            this.label15.TabIndex = 49;
            this.label15.Text = "Extra Price";
            // 
            // extraAvailableLbl
            // 
            this.extraAvailableLbl.AutoSize = true;
            this.extraAvailableLbl.Location = new System.Drawing.Point(510, 58);
            this.extraAvailableLbl.Name = "extraAvailableLbl";
            this.extraAvailableLbl.Size = new System.Drawing.Size(19, 25);
            this.extraAvailableLbl.TabIndex = 48;
            this.extraAvailableLbl.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 25);
            this.label13.TabIndex = 47;
            this.label13.Text = "Extra availabe";
            // 
            // maxPersonLbl
            // 
            this.maxPersonLbl.AutoSize = true;
            this.maxPersonLbl.Location = new System.Drawing.Point(159, 187);
            this.maxPersonLbl.Name = "maxPersonLbl";
            this.maxPersonLbl.Size = new System.Drawing.Size(19, 25);
            this.maxPersonLbl.TabIndex = 46;
            this.maxPersonLbl.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "Max person";
            // 
            // roomPriceLbl
            // 
            this.roomPriceLbl.AutoSize = true;
            this.roomPriceLbl.Location = new System.Drawing.Point(159, 143);
            this.roomPriceLbl.Name = "roomPriceLbl";
            this.roomPriceLbl.Size = new System.Drawing.Size(19, 25);
            this.roomPriceLbl.TabIndex = 44;
            this.roomPriceLbl.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Room Type";
            // 
            // RoomNoLbl
            // 
            this.RoomNoLbl.AutoSize = true;
            this.RoomNoLbl.Location = new System.Drawing.Point(159, 58);
            this.RoomNoLbl.Name = "RoomNoLbl";
            this.RoomNoLbl.Size = new System.Drawing.Size(19, 25);
            this.RoomNoLbl.TabIndex = 40;
            this.RoomNoLbl.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Room No";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.LightCoral;
            this.delBtn.Location = new System.Drawing.Point(1271, 799);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(227, 89);
            this.delBtn.TabIndex = 39;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 1061);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomStatusBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomNoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomDataGridView);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomDataGridView;
        private HBS_DBDataSet3 hBS_DBDataSet3;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private HBS_DBDataSet3TableAdapters.tblRoomTableAdapter tblRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoomNoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomStatusBox;
        private System.Windows.Forms.ComboBox roomTypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label serviceLbl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label extraPriceLbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label extraAvailableLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label maxPersonLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label roomPriceLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label RoomNoLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label roomTypeLbl;
        private System.Windows.Forms.Button delBtn;
    }
}