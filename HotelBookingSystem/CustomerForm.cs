using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class CustomerForm : BaseForm 
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        Customer customer = new Customer();
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hBS_DBDataSet3.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.hBS_DBDataSet3.tblCustomer);

        }

        private void customerDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (customerDataGrid.CurrentRow != null)
            {
                DataGridViewRow row = customerDataGrid.CurrentRow;

                customerIDLabel.Text = row.Cells["customerIDDataGridViewTextBoxColumn"].Value.ToString();
                customerNameBox.Text = row.Cells["customernameDataGridViewTextBoxColumn"].Value.ToString();
                phoneNumberBox.Text = row.Cells["customerphoneDataGridViewTextBoxColumn"].Value.ToString();
                emailBox.Text = row.Cells["customeremailDataGridViewTextBoxColumn"].Value.ToString();
                nrcTypeBox.Text= row.Cells["nrctypeDataGridViewTextBoxColumn"].Value.ToString();
                nrcNoBox.Text = row.Cells["nrcnoDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string customerName = customerNameBox.Text;
            string customerPhone = phoneNumberBox.Text;
            string email =emailBox.Text;
            string nrcType = nrcTypeBox.Text;
            string nrcno = nrcNoBox.Text;
            int nrcNo = Convert.ToInt32(nrcno);

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerPhone))
            {
                MessageBox.Show("Customer can't be added. Please fill Name and Phone correctly.");
                return;
            }
            Customer customer1 = new Customer(customerName,customerPhone,email,nrcType,nrcNo);
            customer1.AddCustomer();
            LoadCustomers();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customerIDLabel.Text);
            string customerName = customerNameBox.Text;
            string customerPhone = phoneNumberBox.Text;
            string email = emailBox.Text;
            string nrcType = nrcTypeBox.Text;
            int nrcNo = Convert.ToInt32(nrcNoBox.Text);
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerPhone) || customerId < 1)
            {
                MessageBox.Show("Customer can't be added. Please fill Name and Phone correctly.");
                return;
            }
            customer.UpdateCustomer(customerId, customerName, customerPhone, email, nrcType, nrcNo);
            LoadCustomers();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customerIDLabel.Text);
            if (customerId < 1)
            {
                MessageBox.Show("Customer can't be deleted.");
                return;
            }
            customer.DeleteCustomer(customerId);
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            DataSet ds = customer.GetCustomers();
            customerDataGrid.DataSource = ds.Tables["tblCustomer"];
        }

    }
}
