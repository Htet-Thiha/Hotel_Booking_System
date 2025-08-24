using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            CreateMenu();

        }

        private void CreateMenu()
        {
            MenuStrip menuStrip = new MenuStrip();
            menuStrip.Dock = DockStyle.Top;
            menuStrip.BackColor = Color.LightBlue;
            menuStrip.ForeColor = Color.White;
            this.Padding = new Padding(0);
            menuStrip.BringToFront();
            
            ToolStripMenuItem homeMenu = new ToolStripMenuItem("Home");
            homeMenu.Click += (s, e) =>
            {
                var home = new HomePage(1);
                home.Show();
                this.Close();
            };

            ToolStripMenuItem bookingMenu = new ToolStripMenuItem("Booking");
            bookingMenu.Click += (s, e) =>
            {
                var booking = new BookingForm();
                booking.Show();
                this.Close();
            };

            ToolStripMenuItem roomsMenu = new ToolStripMenuItem("Rooms");
            roomsMenu.Click += (s, e) =>
            {
                var rooms = new RoomForm();
                rooms.Show();
                this.Close();
            };

            ToolStripMenuItem customersMenu = new ToolStripMenuItem("Customers");
            customersMenu.Click += (s, e) =>
            {
                var customers = new CustomerForm();
                customers.Show();
                this.Close();
            };

            ToolStripMenuItem bookingDetailMenu = new ToolStripMenuItem("BookingDetails");
            bookingDetailMenu.Click += (s, e) =>
            {
                var details = new BookingAndBookingDetail();
                details.Show();
                this.Close();
            };

            ToolStripMenuItem printMenu = new ToolStripMenuItem("Print");
            printMenu.Click += (s, e) =>
            {
                var print = new PrintForm();
                print.Show();
                this.Close();
            };

            ToolStripMenuItem logoutMenu = new ToolStripMenuItem("Logout");
            logoutMenu.Click += (s, e) =>
            {
                var login = new LoginForm();
                login.Show();
                this.Close();
            };

            menuStrip.Items.Add(homeMenu);
            menuStrip.Items.Add(bookingMenu);
            menuStrip.Items.Add(roomsMenu);
            menuStrip.Items.Add(customersMenu);
            menuStrip.Items.Add(bookingDetailMenu);
            menuStrip.Items.Add(logoutMenu);
            menuStrip.Items.Add(printMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }
    }
}
