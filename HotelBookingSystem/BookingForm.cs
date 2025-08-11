using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HotelBookingSystem
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            statusBox.DataSource = new List<string> { "booking", "staying", "canceled" };
            roomStatusBox.DataSource = new List<string> { "all","booked", "available", "checkIn"};
            var roomTypes = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(6, "all"),
                new KeyValuePair<int, string>(1, "Deluxe_Room"),
                new KeyValuePair<int, string>(2, "Premier_Room"),
                new KeyValuePair<int, string>(3, "Executive_Suite"),
                new KeyValuePair<int, string>(4, "Presidential_Suite"),
                new KeyValuePair<int, string>(5, "Family_Room"),              
            };

            roomTypeBox.DataSource = roomTypes;
            roomTypeBox.DisplayMember = "Value";
            roomTypeBox.ValueMember = "Key";
        }

        int customerID;

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";

    
        private void addBtn_Click(object sender, EventArgs e)
        {
          
            int nrcNo = int.Parse(nrcNoBox.Text);

            Customer customer = new Customer(
                customerNameBox.Text,
                phoneNumberBox.Text,
                emailBox.Text,
                nrcTypeBox.Text,
                nrcNo
            );

            int success = customer.AddCustomer();

            if (success > 0)
            {
                MessageBox.Show("Customer added successfully!");
                customerIDLabel.Text = success.ToString();
            }
            else {
                MessageBox.Show("Failed to add customer.");
            }           
      
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void phoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            String phoneNumber = phoneNumberBox.Text;

            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";

            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM tblCustomer WHERE customer_phone = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", phoneNumber);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            Customer customer = new Customer();
                            DataSet customersList = customer.GetCustomersWithPhone(phoneNumber);
                            using (DataShowForm dataForm = new DataShowForm(customersList))
                            {
                                if (dataForm.ShowDialog() == DialogResult.OK)
                                {
                                    DataRow selected = dataForm.SelectedRow;
                                    customerNameBox.Text = selected["customer_name"].ToString();
                                    phoneNumberBox.Text = selected["customer_phone"].ToString();
                                    emailBox.Text = selected["customer_email"].ToString();
                                    nrcTypeBox.Text = selected["nrc_type"].ToString();
                                    nrcNoBox.Text = selected["nrc_no"].ToString();
                                    customerIDLabel.Text = selected["customer_ID"].ToString();
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(customerIDLabel.Text);
            double totalprice = double.Parse(totalPriceLabel.Text);
            string status = statusBox.SelectedItem.ToString();
            Booking booking = new Booking(customerId, checkInDate.Value.Date, checkOutDate.Value.Date, status, bookingDate.Value.Date, totalprice);
           
            int success = booking.AddBooking();
            MessageBox.Show("Bookind ID - " +success.ToString());

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hBS_DBDataSet1.tblRoom' table. You can move, or remove it, as needed.
            this.tblRoomTableAdapter.Fill(this.hBS_DBDataSet1.tblRoom);

        }

        private void LoadRooms(string query, params object[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        foreach (var param in parameters)
                            adapter.SelectCommand.Parameters.AddWithValue("?", param);

                        DataTable filteredRooms = new DataTable();
                        adapter.Fill(filteredRooms);
                        roomDataGridView.DataSource = filteredRooms;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering data: " + ex.Message);
                }
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            int roomType = int.Parse(roomTypeBox.SelectedValue.ToString());
            string roomStatus = roomStatusBox.SelectedItem.ToString();

            if (roomType == 6 && roomStatus == "all")
            {
                LoadRooms("SELECT * FROM tblRoom");
                return;
            }

            if (roomType == 6)
            {
                LoadRooms("SELECT * FROM tblRoom WHERE status = ?", roomStatus);
                return;
            }

            if (roomStatus == "all")
            {
                LoadRooms("SELECT * FROM tblRoom WHERE room_type_ID = ?", roomType);
                return;
            }

            LoadRooms("SELECT * FROM tblRoom WHERE room_type_ID = ? AND status = ?", roomType, roomStatus);
        }


    }
}
