using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace HotelBookingSystem
{
    class Customer
    {
        public string customer_name { get; set; }
        public string phone {get;set;}
        public string email {get; set;}
        public string nrc_type{get;set;}
        public int nrc_no{get;set;}

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";


        public Customer() { }
        public Customer(string CustomerName, string Phone , string Email, string NrcType , int NrcNo)
        {
            customer_name = CustomerName;
            phone = Phone;
            email = Email;
            nrc_type = NrcType;
            nrc_no = NrcNo;
        }

        public int AddCustomer()
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tblCustomer ( customer_name , customer_phone , customer_email,nrc_type, nrc_no ) VALUES (?,?,?,?,?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", customer_name);
                        command.Parameters.AddWithValue("?", phone);
                        command.Parameters.AddWithValue("?", email);
                        command.Parameters.AddWithValue("?", nrc_type);
                        command.Parameters.AddWithValue("?", nrc_no);


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

        public bool DeleteCustomer(int customer_ID)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM tblCustomer WHERE customer_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", customer_ID);
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

        public DataSet GetCustomers()
        {
            DataSet dataSet = new DataSet();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblCustomer";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.Fill(dataSet, "tblCustomer");
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error reading data");
                }
            }

            return dataSet;
        }

        public DataSet GetCustomersWithPhone(string phoneNumber)
        {
            DataSet dataSet = new DataSet();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblCustomer WHERE customer_phone = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@phone", phoneNumber);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(dataSet, "tblCustomer");
                        }
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error reading data");
                }
            }

            return dataSet;
        }


        public bool UpdateCustomer(int customer_ID, string CustomerName, string Phone, string Email, string NrcType, int NrcNo)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tblCustomer SET customer_name = ?, customer_phone = ?, customer_email = ? , nrc_type = ? ,nrc_no = ? WHERE customer_ID = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", CustomerName);
                        command.Parameters.AddWithValue("?", Phone);
                        command.Parameters.AddWithValue("?", Email);
                        command.Parameters.AddWithValue("?", NrcType);
                        command.Parameters.AddWithValue("?", NrcNo);
                        command.Parameters.AddWithValue("?", customer_ID);


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
