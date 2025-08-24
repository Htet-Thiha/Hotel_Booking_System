using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace HotelBookingSystem
{
    public class DataSetPDFMailer
    {
        private DataSet _ds;
        private string _pdfFilePath;
        private int _currentTable;
        private int _currentRow;

        public DataSetPDFMailer(DataSet ds, string pdfFilePath)
        {
            _ds = ds ;
            _pdfFilePath = pdfFilePath;
            _currentTable = 0;
            _currentRow = 0;
        }

        /// <summary>
        /// Export the DataSet to PDF and send via email
        /// </summary>
        public void ExportAndSendEmail(string toEmail, string subject, string body, string smtpEmail, string smtpPassword)
        {
            ExportToPDF();
            SendEmail(toEmail, subject, body, smtpEmail, smtpPassword, _pdfFilePath);
        }

        /// <summary>
        /// Export DataSet to PDF using Microsoft Print to PDF
        /// </summary>
        public void ExportToPDF()
        {
            string folder = Path.GetDirectoryName(_pdfFilePath);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            pd.PrinterSettings.PrintFileName = _pdfFilePath;
            pd.PrintController = new StandardPrintController(); // hide print dialog
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            pd.Print();

            Console.WriteLine("PDF saved to: " + _pdfFilePath);
        }

        /// <summary>
        /// Print DataSet to a physical printer
        /// </summary>
        public void PrintDataSet(string printerName = "")
        {
            PrintDocument pd = new PrintDocument();
            if (!string.IsNullOrEmpty(printerName))
            {
                pd.PrinterSettings.PrinterName = printerName;
            }
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            pd.Print();
            Console.WriteLine("DataSet sent to printer: " + (string.IsNullOrEmpty(printerName) ? pd.PrinterSettings.PrinterName : printerName));
        }

        /// <summary>
        /// Handles drawing the DataSet content on the page
        /// </summary>
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            float startX = 10;
            float startY = 10;
            float rowHeight = 40;
            float tableWidth = e.PageBounds.Width - 20;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            while (_currentTable < _ds.Tables.Count)
            {
                DataTable table = _ds.Tables[_currentTable];

                int colCount = table.Columns.Count;
                float colWidth = tableWidth / colCount;
                float y = startY;

                // Print column headers
                for (int i = 0; i < colCount; i++)
                {
                    RectangleF rect = new RectangleF(startX + i * colWidth, y, colWidth, rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
                    e.Graphics.DrawString(table.Columns[i].ColumnName, font, brush, rect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
                y += rowHeight;

                // Print rows
                while (_currentRow < table.Rows.Count)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        RectangleF rect = new RectangleF(startX + i * colWidth, y, colWidth, rowHeight);
                        e.Graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
                        e.Graphics.DrawString(table.Rows[_currentRow][i].ToString(), font, brush, rect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    }

                    y += rowHeight;

                    // Check for page break
                    if (y + rowHeight > e.MarginBounds.Bottom)
                    {
                        _currentRow++;
                        e.HasMorePages = true;
                        return;
                    }

                    _currentRow++;
                }

                _currentRow = 0;
                _currentTable++;
                startY = y + 20; // spacing between tables
            }

            e.HasMorePages = false;
            _currentTable = 0;
        }

        /// <summary>
        /// Send email with PDF attachment
        /// </summary>
        private void SendEmail(string toEmail, string subject, string body, string smtpEmail, string smtpPassword, string attachmentPath)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(smtpEmail, smtpPassword),
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(smtpEmail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mail.To.Add(toEmail);

                if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
                {
                    mail.Attachments.Add(new Attachment(attachmentPath));
                }

                client.Send(mail);
                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Email error: " + ex.Message,
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                );
            }
        }
    }
}
