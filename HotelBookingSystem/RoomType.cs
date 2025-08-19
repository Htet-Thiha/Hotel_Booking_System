using System;
using System.Data;
using System.Data.OleDb;

namespace HotelBookingSystem
{
    class RoomType
    {
        public int Room_Type_ID { get; set; }
        public string Room_Type { get; set; }
        public double Price_Per_Night { get; set; }
        public int Max_Person { get; set; }
        public bool Extra_Available { get; set; }
        public double Extra_Fee { get; set; }
        public bool Session_Available { get; set; }
        public double Session_Fee { get; set; }

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";

        public RoomType() { }

        public RoomType(string roomType, double price, int maxPerson, bool extraAvailable, double extraFee, bool sessionAvailable, double sessionFee)
        {
            Room_Type = roomType;
            Price_Per_Night = price;
            Max_Person = maxPerson;
            Extra_Available = extraAvailable;
            Extra_Fee = extraFee;
            Session_Available = sessionAvailable;
            Session_Fee = sessionFee;
        }

        public bool AddRoomType()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO tblRoomType 
                                    (room_type, price_per_night, max_person, extra_available, extra_fee, session_available, session_fee) 
                                    VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", Room_Type);
                        command.Parameters.AddWithValue("?", Price_Per_Night);
                        command.Parameters.AddWithValue("?", Max_Person);
                        command.Parameters.AddWithValue("?", Extra_Available);
                        command.Parameters.AddWithValue("?", Extra_Fee);
                        command.Parameters.AddWithValue("?", Session_Available);
                        command.Parameters.AddWithValue("?", Session_Fee);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error adding RoomType: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateRoomType(int roomTypeId, string roomType, double price, int maxPerson, bool extraAvailable, double extraFee, bool sessionAvailable, double sessionFee)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE tblRoomType 
                                    SET room_type = ?, price_per_night = ?, max_person = ?, extra_available = ?, extra_fee = ?, session_available = ?, session_fee = ? 
                                    WHERE room_type_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", roomType);
                        command.Parameters.AddWithValue("?", price);
                        command.Parameters.AddWithValue("?", maxPerson);
                        command.Parameters.AddWithValue("?", extraAvailable);
                        command.Parameters.AddWithValue("?", extraFee);
                        command.Parameters.AddWithValue("?", sessionAvailable);
                        command.Parameters.AddWithValue("?", sessionFee);
                        command.Parameters.AddWithValue("?", roomTypeId);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error updating RoomType: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteRoomType(int roomTypeId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM tblRoomType WHERE room_type_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", roomTypeId);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error deleting RoomType: " + ex.Message);
                    return false;
                }
            }
        }

        public DataSet GetRoomTypes()
        {
            DataSet dataSet = new DataSet();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM tblRoomType";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.Fill(dataSet, "tblRoomType");
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error reading RoomTypes: " + ex.Message);
                }
            }

            return dataSet;
        }

        public DataRow GetRoomTypeById(int roomTypeID)
        {
            DataTable table = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tblRoomType WHERE room_type_ID = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", roomTypeID);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

    }
}
