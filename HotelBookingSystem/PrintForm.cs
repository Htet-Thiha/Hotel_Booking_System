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
    public partial class PrintForm : BaseForm
    {
        public PrintForm()
        {
            InitializeComponent();
        }
        Booking booking = new Booking();
        RoomType roomType = new RoomType();
        Customer customer = new Customer();

        private void PrintForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hBS_DBDataSet2.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter1.Fill(this.hBS_DBDataSet2.tblCustomer);
            // TODO: This line of code loads data into the 'hBS_DBDataSet3.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.hBS_DBDataSet3.tblCustomer);
            // TODO: This line of code loads data into the 'hBS_DBDataSet3.tblRoomType' table. You can move, or remove it, as needed.
            this.tblRoomTypeTableAdapter.Fill(this.hBS_DBDataSet3.tblRoomType);
            // TODO: This line of code loads data into the 'hBS_DBDataSet3.tblBooking' table. You can move, or remove it, as needed.
            this.tblBookingTableAdapter.Fill(this.hBS_DBDataSet3.tblBooking);

        }

        private void bookingPrintBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = booking.GetBookings();
            string pdfPath = @"C:\\Users\\Ngateeth's\\Desktop\\temp";
            DataSetPDFMailer exporter = new DataSetPDFMailer(ds, pdfPath);
            exporter.PrintDataSet();
        }

        private void bookingExportBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = booking.GetBookings();
            string pdfPath = @"C:\\Users\\Ngateeth's\\Desktop\\temp";
            DataSetPDFMailer exporter = new DataSetPDFMailer(ds, pdfPath);
            exporter.ExportToPDF();
        }

        private void roomTypeExportBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = roomType.GetRoomTypes();
            string pdfPath = @"C:\\Users\\Ngateeth's\\Desktop\\temp";
            DataSetPDFMailer exporter = new DataSetPDFMailer(ds, pdfPath);
            exporter.ExportToPDF();
        }

        private void customerExportBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = customer.GetCustomers();
            string pdfPath = @"C:\\Users\\Ngateeth's\\Desktop\\temp";
            DataSetPDFMailer exporter = new DataSetPDFMailer(ds, pdfPath);
            exporter.ExportToPDF();
        }

        private void roomTypePrintBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = roomType.GetRoomTypes();
            string pdfPath = @"C:\\Users\\Ngateeth's\\Desktop\\temp";
            DataSetPDFMailer exporter = new DataSetPDFMailer(ds, pdfPath);
            exporter.PrintDataSet();
        }

        private void customerPrintBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = customer.GetCustomers();
            string pdfPath = @"C:\\Users\\Ngateeth's\\Desktop\\temp";
            DataSetPDFMailer exporter = new DataSetPDFMailer(ds, pdfPath);
            exporter.PrintDataSet();
        }

        private void bookingMailBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = customer.GetCustomers();
            string pdfPath = @"C:\\Users\\Ngateeth's\\Desktop\\temp";
            DataSetPDFMailer exporter = new DataSetPDFMailer(ds, pdfPath);
        }
    }
}
