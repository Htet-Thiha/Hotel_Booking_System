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
            statusBox.DataSource = new List<string> {"booking", "staying", "canceled"};
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
        int roomID;
        int bookingID;
        string selectedRoomNo;
        string roomStatus;
        Room room = new Room();
        List<RoomBooking> selectedRooms = new List<RoomBooking>();



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
                customerID = success;
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
                                    customerID = Convert.ToInt32(selected["customer_ID"].ToString());
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

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hBS_DBDataSet1.tblRoom' table. You can move, or remove it, as needed.
            this.tblRoomTableAdapter.Fill(this.hBS_DBDataSet1.tblRoom);

            
            takenRoomDataGrid.ColumnCount = 4;
            takenRoomDataGrid.Columns[0].Name = "Room ID";
            takenRoomDataGrid.Columns[1].Name = "Room No";
            takenRoomDataGrid.Columns[2].Name = "Nights";
            takenRoomDataGrid.Columns[3].Name = "Total Price";

            
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            takenRoomDataGrid.Columns.Add(deleteButton);

            takenRoomDataGrid.CellClick += takenRoomDataGrid_CellClick;

        }
        private void takenRoomDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == takenRoomDataGrid.Columns["Delete"].Index)
            {
                DataGridViewRow row = takenRoomDataGrid.CurrentRow;
                int deleteID = Convert.ToInt32(row.Cells["Room ID"].Value);
                takenRoomDataGrid.Rows.RemoveAt(e.RowIndex);
                room.UpdateStatusByID(deleteID, "available");
                LoadRooms("SELECT * FROM tblRoom");
            }
            return;
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

        private void roomDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (roomDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = roomDataGridView.CurrentRow;

                if (row.Cells["roomIDDataGridViewTextBoxColumn"].Value != null && row.Cells["roomtypeIDDataGridViewTextBoxColumn"].Value != null)
                {
                    roomID = Convert.ToInt32(row.Cells["roomIDDataGridViewTextBoxColumn"].Value);
                    selectedRoomNo = row.Cells["roomnoDataGridViewTextBoxColumn"].Value.ToString();
                    roomStatus = row.Cells["statusDataGridViewTextBoxColumn"].Value.ToString();
                    int selectedRoomTypeId = Convert.ToInt32(row.Cells["roomtypeIDDataGridViewTextBoxColumn"].Value);

                    RoomType roomType = new RoomType();
                    var roomTypeRow = roomType.GetRoomTypeById(selectedRoomTypeId);

                    if (roomTypeRow != null)
                    {
                        roomTypeLabel.Text = roomTypeRow["room_type"].ToString();
                        priceLabel.Text = roomTypeRow["price_per_night"].ToString();
                        maxGuestLabel.Text = roomTypeRow["max_person"].ToString();
                        extraLabel.Text = roomTypeRow["extra_available"].ToString();
                        extraPriceLabel.Text = roomTypeRow["extra_fee"].ToString();
                        sessionLabel.Text = roomTypeRow["session_available"].ToString();
                        sessionPriceLabel.Text = roomTypeRow["session_fee"].ToString();

                        if (extraLabel.Text == "True")
                        {
                            guestNumberUpDown.Maximum = int.Parse(roomTypeRow["max_person"].ToString()) > 3 ? 2 : 1;
                        }
                        else
                        {
                            guestNumberUpDown.Maximum = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room Type not found.");
                    }
                }
            }
        }

        private void getRoomBtn_Click(object sender, EventArgs e)
       {
           if (roomID != 0 && roomStatus == "available")
           {
               int extraGuest = Convert.ToInt32(guestNumberUpDown.Value);
               int roomPrice = int.Parse(priceLabel.Text.ToString());
               int extraPrice = int.Parse(extraPriceLabel.Text.ToString());
               int netPrice = (extraGuest * extraPrice) + roomPrice;

               DateTime start = checkInDate.Value;
               DateTime end = checkOutDate.Value;
               TimeSpan difference = end - start;
               int totalDays = difference.Days + 1;

               int totalPrice = netPrice * totalDays;

               takenRoomDataGrid.Rows.Add(roomID,selectedRoomNo, totalDays, totalPrice);

               selectedRooms.Add(new RoomBooking
               {
                   RoomID = roomID,
                   ExtraGuest = extraGuest,
                   RoomPrice = totalPrice,
                   ExtraGuestPrice = extraPrice,
                   CheckIn = start,
                   CheckOut = end
               });

               room.UpdateStatusByID(roomID, "booked");
               LoadRooms("SELECT * FROM tblRoom");         
           }
           else {
               MessageBox.Show("room are not available");
           }
       }

        private int booking_add()
        {
            double totalprice = double.Parse(totalPriceLabel.Text);
            string status = statusBox.SelectedItem.ToString();
            string specialRequest = specialRequestBox.Text.ToString();
            double depositAmount = double.Parse(depositAmountBox.Text);
            int totalGuest = 0;
            if (!string.IsNullOrWhiteSpace(totalGuestBox.Text))
            {
                totalGuest = Convert.ToInt32(totalGuestBox.Text);
            }
            if (totalGuest != 0) {
                Booking booking = new Booking(customerID, status, bookingDate.Value.Date, totalprice, totalGuest, specialRequest, depositAmount);

                int success = booking.AddBooking();
                MessageBox.Show("Bookind ID - " + success.ToString());
                return success;
            }
            MessageBox.Show("Booking information is not correct");
            return -1;
           
        }

        private double GetTotalPriceFromGrid()
        {
            double totalPrice = 0;

            foreach (DataGridViewRow row in takenRoomDataGrid.Rows)
            {
                if (row.Cells["Total Price"].Value != null)
                {
                    totalPrice += Convert.ToDouble(row.Cells["Total Price"].Value);
                }
            }

            return totalPrice;
        }

        private void AddBookingDetail(int bookingId)
        {
            foreach (var roomBooking in selectedRooms)
            {
                BookingDetail detail = new BookingDetail(
                    bookingID,
                    roomBooking.RoomID,
                    roomBooking.ExtraGuest,
                    roomBooking.ExtraGuestPrice,
                    roomBooking.RoomPrice,
                    roomBooking.CheckIn,
                    roomBooking.CheckOut
                );
                detail.AddBookingDetail();
            }

            MessageBox.Show("Booking completed successfully!");
            ResetBookingForm();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {

            double totalPrice = GetTotalPriceFromGrid();
            totalPriceLabel.Text = totalPrice.ToString();

            if (customerID != 0)
            {
                bookingID = booking_add();
                if (bookingID < 1 || customerID < 1)
                {
                    MessageBox.Show("Booking Error");
                    return;
                }
                AddBookingDetail(bookingID);
            }
            else {
                MessageBox.Show("Please provide customer Data");
            }            

        }

        private void ResetBookingForm()
        {
            customerNameBox.Text = "";
            phoneNumberBox.Text = "";
            emailBox.Text = "";
            nrcTypeBox.Text = "";
            nrcNoBox.Text = "";
            customerIDLabel.Text = "0";
            customerID = 0;

            selectedRooms.Clear();
            takenRoomDataGrid.Rows.Clear();

            roomTypeLabel.Text = "";
            priceLabel.Text = "0";
            maxGuestLabel.Text = "0";
            extraLabel.Text = "False";
            extraPriceLabel.Text = "0";
            sessionLabel.Text = "False";
            sessionPriceLabel.Text = "0";

            guestNumberUpDown.Value = 0;
            checkInDate.Value = DateTime.Today;
            checkOutDate.Value = DateTime.Today;

            totalPriceLabel.Text = "0";
            totalGuestBox.Text = "";
            specialRequestBox.Text = "";
            depositAmountBox.Text = "0";
        }



        


    }
}
