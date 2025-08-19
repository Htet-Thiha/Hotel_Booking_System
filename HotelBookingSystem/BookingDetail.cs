using System;
using System.Data;
using System.Data.OleDb;

namespace HotelBookingSystem
{
    class BookingDetail
    {
        public int booking_ID { get; set; }
        public int room_ID { get; set; }
        public int extra_guest { get; set; }
        public double extra_guest_price { get; set; }
        public double room_price { get; set; }
        public DateTime check_in_date { get; set; }
        public DateTime check_out_date { get; set; }

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";

        public BookingDetail() { }

        public BookingDetail(int bookingId, int roomId, int extraGuest, double extraGuestPrice, double roomPrice, DateTime checkIn, DateTime checkOut)
        {
            booking_ID = bookingId;
            room_ID = roomId;
            extra_guest = extraGuest;
            extra_guest_price = extraGuestPrice;
            room_price = roomPrice;
            check_in_date = checkIn;
            check_out_date = checkOut;
        }

        public bool AddBookingDetail()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO tblBookingDetail 
                                    (booking_ID, room_ID, extra_guest, extra_guest_price, room_price, check_in_date, check_out_date) 
                                     VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add("?", OleDbType.Integer).Value = booking_ID;
                        command.Parameters.Add("?", OleDbType.Integer).Value = room_ID;
                        command.Parameters.Add("?", OleDbType.Integer).Value = extra_guest;
                        command.Parameters.Add("?", OleDbType.Currency).Value = extra_guest_price;
                        command.Parameters.Add("?", OleDbType.Currency).Value = room_price;
                        command.Parameters.Add("?", OleDbType.Date).Value = check_in_date;
                        command.Parameters.Add("?", OleDbType.Date).Value = check_out_date;

                        int result = command.ExecuteNonQuery();

                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error adding booking detail: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteBookingDetail(int bookingDetailId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM tblBookingDetail WHERE booking_detail_ID = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", bookingDetailId);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public DataSet GetBookingDetails()
        {
            DataSet dataSet = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM tblBookingDetail";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.Fill(dataSet, "tblBookingDetail");
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error reading booking details data");
                }
            }
            return dataSet;
        }

        public DataSet GetBookingDetailsByBookingId(int bookingID)
        {
            DataSet dataSet = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM tblBookingDetail where booking_ID = ?";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("?", bookingID);

                        adapter.Fill(dataSet,"tblBookingDetail");
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error reading booking details data");
                }
            }
            return dataSet;
        }


        public bool UpdateBookingDetail(int bookingDetailId, int roomId, int extraGuest, double extraGuestPrice, double roomPrice, DateTime checkIn, DateTime checkOut)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"UPDATE tblBookingDetail 
                                     SET room_ID = ?, extra_guest = ?, extra_guest_price = ?, room_price = ?, check_in_date = ?, check_out_date = ? 
                                     WHERE booking_detail_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", roomId);
                        command.Parameters.AddWithValue("?", extraGuest);
                        command.Parameters.AddWithValue("?", extraGuestPrice);
                        command.Parameters.AddWithValue("?", roomPrice);
                        command.Parameters.AddWithValue("?", checkIn);
                        command.Parameters.AddWithValue("?", checkOut);
                        command.Parameters.AddWithValue("?", bookingDetailId);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
