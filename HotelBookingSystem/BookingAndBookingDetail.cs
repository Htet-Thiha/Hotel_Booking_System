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
    public partial class BookingAndBookingDetail : BaseForm 
    {
        public BookingAndBookingDetail()
        {
            InitializeComponent();
        }
        int bookingId = 0;
        int customerID = 0;
        int bookingDetailId = 0;
        Booking booking = new Booking();
        BookingDetail bookingDetail = new BookingDetail();
        Customer customer = new Customer();


        private void BookingAndBookingDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hBS_DBDataSet3.tblBookingDetail' table. You can move, or remove it, as needed.
            this.tblBookingDetailTableAdapter.Fill(this.hBS_DBDataSet3.tblBookingDetail);
            // TODO: This line of code loads data into the 'hBS_DBDataSet3.tblBooking' table. You can move, or remove it, as needed.
            this.tblBookingTableAdapter.Fill(this.hBS_DBDataSet3.tblBooking);

        }

        private void bookingSearchBtn_Click(object sender, EventArgs e)
        {
            DataSet searchCustomers;

            string key = bookingSearchBox.Text.ToString();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter a search value.");
                bookingDataGrid.DataSource = booking.GetBookings().Tables["tblBooking"];
                return;
            }

            if (key.All(char.IsDigit))
            {
                searchCustomers = customer.SearchCustomersWithPhone(key);
            }
            else
            {
                searchCustomers = customer.SerachCustomersWithName(key);
            }

            if (searchCustomers.Tables.Count == 0 || searchCustomers.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No matching customers found.");
                return;
            }

            using (DataShowForm dataForm = new DataShowForm(searchCustomers))
            {
                if (dataForm.ShowDialog() == DialogResult.OK)
                {
                    DataRow selected = dataForm.SelectedRow;
                    customerID = Convert.ToInt32(selected["customer_ID"]);
                }
            }

            if (customerID > 0)
            {
                bookingDataGrid.DataSource = booking.GetBookingsByCustomerID(customerID).Tables["tblBooking"];
            }
        }

        private void bookingDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (bookingDataGrid.CurrentRow != null)
            {
                DataGridViewRow row = bookingDataGrid.CurrentRow;
                bookingId = Convert.ToInt32(row.Cells["booking_ID"].Value);
                totalGuestBox.Text = row.Cells["total_guest"].Value.ToString();
                specialRequestBox.Text = row.Cells["special_request"].Value.ToString();
                depositBox.Text = row.Cells["deposit_amount"].Value.ToString();

                if (bookingId > 0)
                {
                    DataSet bookingDetails = bookingDetail.GetBookingDetailsByBookingId(bookingId);
                    bookingDetailDataGrid.DataSource = bookingDetails.Tables["tblBookingDetail"];
                }

            }
        }

        private void booingUpdateBtn_Click(object sender, EventArgs e)
        {
            int totalGuest = Convert.ToInt32(totalGuestBox.Text);
            double depositAmount = Convert.ToDouble(depositBox.Text);
            string specialRequest = specialRequestBox.Text;
            if (double.IsNaN(depositAmount) || bookingId < 1)
            {
                MessageBox.Show("Booking can't be updated");
                return;
            }
            booking.UpdateBookingMinor(bookingId,totalGuest,specialRequest,depositAmount);
            LoadBooking();

        }

        private void bookingDeleteBtn_Click(object sender, EventArgs e)
        {
            if (bookingId < 1)
            {
                MessageBox.Show("Booking can't be deleted");
                return;
            }
            booking.DeleteBooking(bookingId);
            LoadBooking();
        }

        private void LoadBooking()
        {
            DataSet ds = booking.GetBookings();
            bookingDataGrid.DataSource = ds.Tables["tblBooking"];
        }

        private void bookingDetailDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (bookingDetailDataGrid.CurrentRow != null)
            {
                DataGridViewRow row = bookingDetailDataGrid.CurrentRow;
                bookingDetailId = Convert.ToInt32(row.Cells["booking_detail_ID"].Value);
                guestNumberUpDown.Value = Convert.ToInt32(row.Cells["extra_guest"].Value);
                checkInDate.Value = Convert.ToDateTime(row.Cells["check_in_date"].Value);
                checkOutDate.Value = Convert.ToDateTime(row.Cells["check_out_date"].Value);
    

            }
        }

        private void bookingDetailDeleteBtn_Click(object sender, EventArgs e)
        {
            if (bookingDetailId < 1)
            {
                MessageBox.Show("Booking can't be deleted");
                return;
            }
            bookingDetail.DeleteBookingDetail(bookingDetailId);
            LoadBookingDetail();

        }

        private void bookingDetailUpdateBtn_Click(object sender, EventArgs e)
        {
            int extraGuest = Convert.ToInt32(guestNumberUpDown.Value);
            DateTime check_In_Date = checkInDate.Value.Date;
            DateTime check_Out_Date = checkOutDate.Value.Date;
            bookingDetail.UpdateBookingDetailMinor(bookingDetailId, extraGuest, check_In_Date, check_Out_Date);
            LoadBookingDetail();
        }

        private void LoadBookingDetail()
        {
            DataSet ds = bookingDetail.GetBookingDetailsByBookingId(bookingId);
            bookingDetailDataGrid.DataSource = ds.Tables["tblBookingDetail"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = booking.GetBookings();
            string pdfPath = @"C:\\Users\\Ngateeth's\\Desktop\\temp";
            DataSetPDFMailer exporter = new DataSetPDFMailer(ds, pdfPath);
            exporter.ExportToPDF();
        }
    }
}
