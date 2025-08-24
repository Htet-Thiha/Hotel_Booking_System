using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace HotelBookingSystem
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserRole { get; set; }

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";

        public User() { }

        public User(string user_Name, string password, int user_Role)
        {
            UserName = user_Name;
            Password = password;
            UserRole = user_Role;
        }

        // Add new user
        public int AddUser()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tblUser (UserName, Password, UserRole) VALUES (?,?,?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", UserName);
                        command.Parameters.AddWithValue("?", Password);
                        command.Parameters.AddWithValue("?", UserRole);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            using (OleDbCommand idCommand = new OleDbCommand("SELECT @@IDENTITY", connection))
                            {
                                object idObj = idCommand.ExecuteScalar();
                                if (idObj != null)
                                    return int.Parse(idObj.ToString());
                            }
                        }
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error adding user: " + ex.Message);
                    return -1;
                }
            }
        }

        // Delete user by ID
        public bool DeleteUser(int userID)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM tblUser WHERE UserID = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", userID);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error deleting user: " + ex.Message);
                    return false;
                }
            }
        }

        
        public DataSet GetUsers()
        {
            DataSet dataSet = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM tblUser";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.Fill(dataSet, "tblUser");
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error reading users: " + ex.Message);
                }
            }
            return dataSet;
        }

        // Get user by ID
        public DataRow GetUserByID(int userID)
        {
            DataTable table = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM tblUser WHERE UserID = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", userID);
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error reading user: " + ex.Message);
                }
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        // Update user
        public bool UpdateUser(int userID, string userName, string password, int userRole)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE tblUser SET UserName = ?, Password = ?, UserRole = ? WHERE UserID = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", userName);
                        command.Parameters.AddWithValue("?", password);
                        command.Parameters.AddWithValue("?", userRole);
                        command.Parameters.AddWithValue("?", userID);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error updating user: " + ex.Message);
                    return false;
                }
            }
        }

        // Search users by username
        public DataSet SearchUsersByName(string namePart)
        {
            DataSet dataSet = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM tblUser WHERE UserName LIKE ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", "%" + namePart + "%");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(dataSet, "tblUser");
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error searching users: " + ex.Message);
                }
            }
            return dataSet;
        }
    }
}


