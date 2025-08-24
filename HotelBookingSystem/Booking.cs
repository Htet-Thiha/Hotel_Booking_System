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
        public string Status { get; set; }
        public DateTime booking_date { get; set; }
        public int total_guest { get; set; }
        public string special_request { get; set; }
        public double deposit_amount { get; set; }

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";

        public Booking() {}

        public Booking(int customerID, string status, DateTime bookingDate, double totalPrice, int totalGuest, string specialRequest, double depositAmount)
        {
            customer_ID = customerID;
            booking_date = bookingDate;
            Status = status;
            total_price = totalPrice;
            total_guest = totalGuest;
            special_request = specialRequest;
            deposit_amount = depositAmount;

        }

        public int AddBooking()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tblBooking (customer_ID, status,booking_date,total_price,total_guest,special_request,deposit_amount) VALUES (?,?, ?, ?, ?,?,?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add("?", OleDbType.Integer).Value = customer_ID;
                        command.Parameters.Add("?", OleDbType.VarChar).Value = Status;
                        command.Parameters.Add("?", OleDbType.Date).Value = booking_date;
                        command.Parameters.Add("?", OleDbType.Currency).Value = total_price;
                        command.Parameters.Add("?", OleDbType.Integer).Value = total_guest;
                        command.Parameters.Add("?", OleDbType.VarChar).Value = special_request;
                        command.Parameters.Add("?", OleDbType.Currency).Value = deposit_amount;



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

        public DataSet GetBookingsByCustomerID(int customerID)
        {
            DataSet dataSet = new DataSet();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblBooking WHERE customer_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", customerID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(dataSet, "tblBooking");
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error reading booking data: " + ex.Message);
                }
            }

            return dataSet;
        }

        public bool UpdateBooking(int bookingId, int customerID,  string status,DateTime bookingDate,int totalPrice,int totalGuest,string specialRequest, double depositAmount)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tblBooking SET customer_ID = ?, status = ?, booking_date = ?,total_price = ?,total_guest = ?,special_request =? , deposit_amount = ? WHERE booking_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", customerID);
                        command.Parameters.AddWithValue("?", status);
                        command.Parameters.AddWithValue("?", bookingDate);
                        command.Parameters.AddWithValue("?", totalPrice);
                        command.Parameters.AddWithValue("?", bookingId);
                        command.Parameters.AddWithValue("?", totalGuest);
                        command.Parameters.AddWithValue("?", specialRequest);
                        command.Parameters.AddWithValue("?", depositAmount);

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

        public bool UpdateBookingMinor(int bookingId, int totalGuest, string specialRequest, double depositAmount)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tblBooking SET total_guest = ?,special_request =? , deposit_amount = ? WHERE booking_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("?", totalGuest);
                        command.Parameters.AddWithValue("?", specialRequest);
                        command.Parameters.AddWithValue("?", depositAmount);
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


        public bool UpdateBookingStatus(int bookingId,string status)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tblBooking SET status = ? WHERE booking_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", status);
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

        public int GetTotalGuestsByStatus(string status)
        {
            int totalGuests = 0;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(total_guest) FROM tblBooking WHERE status = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", status);

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            totalGuests = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error calculating total guests: " + ex.Message);
                }
            }

            return totalGuests;
        }


    }
}
