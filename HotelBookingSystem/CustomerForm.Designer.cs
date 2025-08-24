namespace HotelBookingSystem
{
    partial class CustomerForm
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
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hBS_DBDataSet3 = new HotelBookingSystem.HBS_DBDataSet3();
            this.tblCustomerTableAdapter = new HotelBookingSystem.HBS_DBDataSet3TableAdapters.tblCustomerTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrctypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nrcNoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nrcTypeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.hBS_DBDataSet3;
            // 
            // hBS_DBDataSet3
            // 
            this.hBS_DBDataSet3.DataSetName = "HBS_DBDataSet3";
            this.hBS_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.deleteBtn.Location = new System.Drawing.Point(1350, 638);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(153, 75);
            this.deleteBtn.TabIndex = 42;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToAddRows = false;
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.AutoGenerateColumns = false;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customeremailDataGridViewTextBoxColumn,
            this.nrctypeDataGridViewTextBoxColumn,
            this.nrcnoDataGridViewTextBoxColumn});
            this.customerDataGrid.DataSource = this.tblCustomerBindingSource;
            this.customerDataGrid.Location = new System.Drawing.Point(73, 107);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.RowTemplate.Height = 33;
            this.customerDataGrid.Size = new System.Drawing.Size(836, 928);
            this.customerDataGrid.TabIndex = 41;
            this.customerDataGrid.SelectionChanged += new System.EventHandler(this.customerDataGrid_SelectionChanged);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            // 
            // customeremailDataGridViewTextBoxColumn
            // 
            this.customeremailDataGridViewTextBoxColumn.DataPropertyName = "customer_email";
            this.customeremailDataGridViewTextBoxColumn.HeaderText = "customer_email";
            this.customeremailDataGridViewTextBoxColumn.Name = "customeremailDataGridViewTextBoxColumn";
            // 
            // nrctypeDataGridViewTextBoxColumn
            // 
            this.nrctypeDataGridViewTextBoxColumn.DataPropertyName = "nrc_type";
            this.nrctypeDataGridViewTextBoxColumn.HeaderText = "nrc_type";
            this.nrctypeDataGridViewTextBoxColumn.Name = "nrctypeDataGridViewTextBoxColumn";
            // 
            // nrcnoDataGridViewTextBoxColumn
            // 
            this.nrcnoDataGridViewTextBoxColumn.DataPropertyName = "nrc_no";
            this.nrcnoDataGridViewTextBoxColumn.HeaderText = "nrc_no";
            this.nrcnoDataGridViewTextBoxColumn.Name = "nrcnoDataGridViewTextBoxColumn";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(1220, 330);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(19, 25);
            this.customerIDLabel.TabIndex = 40;
            this.customerIDLabel.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1024, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "Customer ID";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.LightBlue;
            this.updateBtn.Location = new System.Drawing.Point(1156, 638);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(153, 75);
            this.updateBtn.TabIndex = 38;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addBtn.Location = new System.Drawing.Point(960, 638);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(153, 75);
            this.addBtn.TabIndex = 37;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1024, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nrc No";
            // 
            // nrcNoBox
            // 
            this.nrcNoBox.Location = new System.Drawing.Point(1214, 519);
            this.nrcNoBox.Name = "nrcNoBox";
            this.nrcNoBox.Size = new System.Drawing.Size(224, 31);
            this.nrcNoBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1024, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nrc type";
            // 
            // nrcTypeBox
            // 
            this.nrcTypeBox.Location = new System.Drawing.Point(1214, 482);
            this.nrcTypeBox.Name = "nrcTypeBox";
            this.nrcTypeBox.Size = new System.Drawing.Size(224, 31);
            this.nrcTypeBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(1214, 445);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(224, 31);
            this.emailBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1024, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Phone number";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(1214, 408);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(224, 31);
            this.phoneNumberBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1024, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Customer Name";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(1214, 371);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(224, 31);
            this.customerNameBox.TabIndex = 27;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1073);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.label13);
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
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBS_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nrcNoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nrcTypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private HBS_DBDataSet3 hBS_DBDataSet3;
        private HBS_DBDataSet3TableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrctypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
    }
}