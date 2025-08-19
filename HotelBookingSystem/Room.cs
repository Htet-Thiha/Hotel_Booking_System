using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace HotelBookingSystem
{
    class Room
    {
        public string Room_No { get; set; }
        public int Room_Type_ID { get; set; }
        public string Status { get; set; }

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";


        public Room() { }
        public Room(string roomNo, int roomTypeId, string status)
        {
            Room_No = roomNo;
            Room_Type_ID = roomTypeId;
            Status = status;
        }

        public bool AddRoom()
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tblRoom ( room_no, room_type_ID, status ) VALUES (?, ?,?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", Room_No);
                        command.Parameters.AddWithValue("?", Room_Type_ID);
                        command.Parameters.AddWithValue("?", Status);

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

        public bool DeleteRoom(int roomId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM tblRoom WHERE room_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", roomId);
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

        public DataSet GetRooms()
        {
            DataSet dataSet = new DataSet();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblRoom";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.Fill(dataSet, "tblRoom");
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error reading data");
                }
            }

            return dataSet;
        }

        public bool UpdateRoom(int roomId, string roomNo, int roomTypeId, string status)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tblRoom SET room_no = ?, room_type_ID = ?, status = ? WHERE room_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", roomNo);
                        command.Parameters.AddWithValue("?", roomTypeId);
                        command.Parameters.AddWithValue("?", status);
                        command.Parameters.AddWithValue("?", roomId);

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

        public bool UpdateRoomStatus(int roomId,string status)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tblRoom SET status = ? WHERE room_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", status);
                        command.Parameters.AddWithValue("?", roomId);

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

        public bool UpdateStatusByID(int roomId, string status)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tblRoom SET status = ? WHERE room_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", status);
                        command.Parameters.AddWithValue("?", roomId);

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

        public DataRow GetRoomById(int roomId)
        {
            DataTable table = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblRoom WHERE room_ID = ?";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("?", roomId);

                        adapter.Fill(table);
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error fetching room by ID");
                }
            }

            if (table.Rows.Count > 0)
                return table.Rows[0];
            else
                return null;
        }

        public int GetTotalRoomsByStatus(string status)
        {
            int totalRooms = 0;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM tblRoom WHERE status = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", status);

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            totalRooms = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error calculating total rooms: " + ex.Message);
                }
            }

            return totalRooms;
        }

    }


}