using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class AuthForm : Form
    {
        private int _receivedId;

        public AuthForm(int id)
        {
            InitializeComponent();
            _receivedId = id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) == _receivedId)
            {
                Form homePage = new HomePage(_receivedId);
                homePage.Show();
                this.Close();
                return;
               
            }
            MessageBox.Show("error");
        }
    }
}
