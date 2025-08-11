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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hBS_DBDataSet.tblBooking' table. You can move, or remove it, as needed.
            this.tblBookingTableAdapter.Fill(this.hBS_DBDataSet.tblBooking);

        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BookingForm = new BookingForm();
            BookingForm.Show();
        }

    }
}
