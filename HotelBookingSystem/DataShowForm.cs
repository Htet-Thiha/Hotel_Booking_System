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
    public partial class DataShowForm : Form
    {
        public DataRow SelectedRow { get; private set; }
        public DataShowForm(DataSet dataSet)
        {
            InitializeComponent();
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            DataRowView callbackData = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;

            if (callbackData != null)
            {
                SelectedRow = callbackData.Row;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
