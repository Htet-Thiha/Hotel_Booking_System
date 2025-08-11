using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace HotelBookingSystem
{
    class Booking
    {
        public double total_price { get; set; }
        public int customer_ID { get; set; }
        public DateTime check_in_date { get; set; }
        public DateTime check_out_date { get; set; }
        public string Status { get; set; }
        public DateTime booking_date { get; set; }

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";

        public Booking() {}

        public Booking(int customerID, DateTime checkIn, DateTime checkOut, string status, DateTime bookingDate, double totalPrice)
        {
            customer_ID = customerID;
            check_in_date = checkIn;
            check_out_date = checkOut;
            booking_date = bookingDate;
            Status = status;
            total_price = totalPrice;

        }

        public int AddBooking()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tblBooking (customer_ID, check_in_Date, check_out_Date, status,booking_date,total_price) VALUES (?, ?, ?, ?, ?,?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add("?", OleDbType.Integer).Value = customer_ID;
                        command.Parameters.Add("?", OleDbType.Date).Value = check_in_date;
                        command.Parameters.Add("?", OleDbType.Date).Value = check_out_date;
                        command.Parameters.Add("?", OleDbType.VarChar).Value = Status;
                        command.Parameters.Add("?", OleDbType.Date).Value = booking_date;
                        command.Parameters.Add("?", OleDbType.Currency).Value = total_price;

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            using (OleDbCommand idCommand = new OleDbCommand("SELECT @@IDENTITY", connection))
                            {
                                object idObj = idCommand.ExecuteScalar();
                                if (idObj != null)
                                {
                                    int newId = int.Parse(idObj.ToString());
                                    return newId;
                                }
                            }
                        }
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);

                    return -1;
                }
            }
        }

        public bool DeleteBooking(int bookingId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM tblBooking WHERE booking_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", bookingId);

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

        public DataSet GetBookings()
        {
            DataSet dataSet = new DataSet();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblBooking";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.Fill(dataSet, "tblBooking");
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error reading booking data");
                }
            }

            return dataSet;
        }

        public bool UpdateBooking(int bookingId, int customerID, DateTime checkIn, DateTime checkOut, string status,DateTime bookingDate,int totalPrice)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tblBooking SET customer_ID = ?, check_in_Date = ?, check_out_Date = ?, status = ?, booking_date = ?,total_price = ? WHERE booking_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", customerID);
                        command.Parameters.AddWithValue("?", checkIn);
                        command.Parameters.AddWithValue("?", checkOut);
                        command.Parameters.AddWithValue("?", status);
                        command.Parameters.AddWithValue("?", bookingDate);
                        command.Parameters.AddWithValue("?", totalPrice);
                        command.Parameters.AddWithValue("?", bookingId);

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
