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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosed += LoginForm_FormClosed;
        }
        User user = new User();
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userTextBox.Text;
            string password = passTextBox.Text;

            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ngateeth's\Documents\HBS_DB.mdb";

            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT UserID, UserRole FROM tblUser WHERE UserName = ? AND Password = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", userName);
                        command.Parameters.AddWithValue("?", password);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // user exists
                            {
                                int userID = Convert.ToInt32(reader["UserID"]);
                                int userRole = Convert.ToInt32(reader["UserRole"]);


                                if (userRole > 1) {
                                    AuthForm auth = new AuthForm(userRole);
                                    auth.Show();
                                    this.Hide();
                                    return;
                               }

                                HomePage homePage = new HomePage(userRole);
                                homePage.Show();
                                this.Hide();
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show(
                                    "Invalid username or password.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
