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
    public partial class HomePage : BaseForm 
    {
        private int _receivedId;
        public HomePage(int id)
        {
            InitializeComponent();
            _receivedId = id;
            ShowStatus();
            authCheck();
            
        }
        int customerID;
        int bookingID;
        Customer customer = new Customer();
        Booking booking = new Booking();
        Room room = new Room();
        double dueAmount =0;
        double depositAmount = 0;
        private void HomePage_Load(object sender, EventArgs e)
        {
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
                customerNameBox.Text = "";
                customerPhoneBox.Text ="";
                bookingGrid.DataSource = booking.GetBookings().Tables["tblBooking"];
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
                    customerNameBox.Text = selected["customer_name"].ToString();
                    customerPhoneBox.Text = selected["customer_phone"].ToString();
                    customerID = Convert.ToInt32(selected["customer_ID"]);
                }
            }

            if (customerID > 0)
            {
                bookingGrid.DataSource = booking.GetBookingsByCustomerID(customerID).Tables["tblBooking"];
            }
        }

        private void bookingGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (bookingGrid.CurrentRow != null)
            {
                DataGridViewRow row = bookingGrid.CurrentRow;
                customerID = Convert.ToInt32(row.Cells["customerIDDataGridViewTextBoxColumn"].Value);
                bookingID = Convert.ToInt32(row.Cells["bookingIDDataGridViewTextBoxColumn"].Value);
                var customerRow = customer.GetCustomersWithID(customerID);

                customerNameBox.Text = customerRow["customer_name"].ToString();
                customerPhoneBox.Text = customerRow["customer_phone"].ToString();
                totalPriceBox.Text = row.Cells["totalpriceDataGridViewTextBoxColumn"].Value.ToString();
                depositBox.Text = row.Cells["depositamountDataGridViewTextBoxColumn"].Value.ToString();
                guestBox.Text = row.Cells["totalguestDataGridViewTextBoxColumn"].Value.ToString();
                specialRequestBox.Text = row.Cells["specialrequestDataGridViewTextBoxColumn"].Value.ToString();
                double totalPrice = 0;
                
                if (!double.TryParse(totalPriceBox.Text, out totalPrice))
                {
                    totalPrice = 0;
                }
                if (!double.TryParse(depositBox.Text, out depositAmount))
                {
                    depositAmount = 0;
                }
                dueAmount = totalPrice - depositAmount;
                dueAmountBox.Text = dueAmount.ToString();
                

            }
        }

        private void chechInBtn_Click(object sender, EventArgs e)
        {
            BookingDetail bookingdDetail = new BookingDetail();
            booking.UpdateBookingStatus(bookingID, "checkIn");
            DataSet bookingDetailList = bookingdDetail.GetBookingDetailsByBookingId(bookingID);
            if (bookingDetailList != null && bookingDetailList.Tables.Count > 0)
            {
                DataTable dt = bookingDetailList.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    int roomID = Convert.ToInt32(row["room_ID"]);
                    room.UpdateStatusByID(roomID, "checkIn");
                }
            }
            ResetForm();
        }

        private void chechOutBtn_Click(object sender, EventArgs e)
        {
            if (dueAmount != 0)
            {
                MessageBox.Show("Pay the bill first");
                return;
            }
            BookingDetail bookingdDetail = new BookingDetail();
            booking.UpdateBookingStatus(bookingID, "checkOut");
            DataSet bookingDetailList = bookingdDetail.GetBookingDetailsByBookingId(bookingID);
            if (bookingDetailList != null && bookingDetailList.Tables.Count > 0)
            {
                DataTable dt = bookingDetailList.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    int roomID = Convert.ToInt32(row["room_ID"]);
                    room.UpdateStatusByID(roomID, "available");
                }
            }
            ResetForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (depositAmount != 0)
            {
                MessageBox.Show("Need to pay back deposit");
                return;
            }
            BookingDetail bookingdDetail = new BookingDetail();
            booking.UpdateBookingStatus(bookingID, "cancel");
            DataSet bookingDetailList = bookingdDetail.GetBookingDetailsByBookingId(bookingID);
            if (bookingDetailList != null && bookingDetailList.Tables.Count > 0)
            {
                DataTable dt = bookingDetailList.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    int roomID = Convert.ToInt32(row["room_ID"]);
                    room.UpdateStatusByID(roomID, "available");
                }
            }
            ResetForm();
        }

        private void authCheck() {
            if (_receivedId == 1) {
                cancelBtn.Visible = false;
            }

        }

        private void ResetForm()
        {
            customerNameBox.Text = "";
            customerPhoneBox.Text = "";
            totalPriceBox.Text = "";
            depositBox.Text = "";
            guestBox.Text = "";
            specialRequestBox.Text = "";
            bookingSearchBox.Text = "";

            customerID = 0;
            bookingID = 0;

            bookingGrid.DataSource = booking.GetBookings().Tables["tblBooking"];

            if (bookingGrid.CurrentRow != null)
                bookingGrid.ClearSelection();
        }

        private void ShowStatus()
        {
            availableRooms.Text = room.GetTotalRoomsByStatus("available").ToString();
            currentGuest.Text = booking.GetTotalGuestsByStatus("checkIn").ToString();
        }
       

      

    }
}
