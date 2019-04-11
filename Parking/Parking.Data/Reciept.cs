using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using Parking.Entity;
namespace Parking.Data
{
    public class Reciept
    {
             PrintDocument pdoc = null;

             User user;

             public Reciept(User user)
             {
                 this.user = user;
             }
             public void print()
             {
                 PrintDialog pd = new PrintDialog();
                 pdoc = new PrintDocument();
                 PrinterSettings ps = new PrinterSettings();
                 Font font = new Font("Courier New", 10);


                 PaperSize psize = new PaperSize("Aiub-Parking", 600, 400);

                 pd.Document = pdoc;
                 pd.Document.DefaultPageSettings.PaperSize = psize;
                 pdoc.DefaultPageSettings.PaperSize.Height = 400;

                 pdoc.DefaultPageSettings.PaperSize.Width = 600;

                 pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

                 DialogResult result = pd.ShowDialog();
                 if (result == DialogResult.OK)
                 {
                     PrintPreviewDialog pp = new PrintPreviewDialog();
                     pp.Document = pdoc;
                     result = pp.ShowDialog();
                     if (result == DialogResult.OK)
                     {
                         pdoc.Print();
                     }
                 }

             }
             void pdoc_PrintPage(object sender, PrintPageEventArgs e)
             {
                 try
                 {
                     Graphics graphics = e.Graphics;
                     graphics.DrawRectangle(Pens.Black, 5, 5, 600, 400);

                     string title = Application.StartupPath + "\\logo.png";
                     Image yourImage = (Image)(new Bitmap(Image.FromFile(title), new Size(90, 90)));

                     graphics.DrawImage(yourImage, 250, 20);



                     Font font = new Font("Courier New", 15);
                     SolidBrush brush = new SolidBrush(Color.Black);
                     float fontHeight = font.GetHeight();
                     int startX = 20;
                     int startY = 40;
                     int Offset = 70;
                     graphics.DrawString("---------------AIUB Parking----------------", font, brush, startX, startY + Offset);

                     font = new Font("Courier New", 10);
                     Offset = Offset + 25;
                     graphics.DrawString("Customer Name: : " + user.name, font, brush, startX, startY + Offset);
                     Offset = Offset + 25;
                     graphics.DrawString("Vehicle No : " + user.vehicleNo, font, brush, startX, startY + Offset);
                     Offset = Offset + 25;
                     graphics.DrawString("Contact no: " + user.phoneNo, font, brush, startX, startY + Offset);
                     Offset = Offset + 25;
                     graphics.DrawString("Parking Floor: " + user.floor, font, brush, startX, startY + Offset);
                     Offset = Offset + 25;
                     graphics.DrawString("Parked Time : " + user.arrivalTime , font, brush, startX, startY + Offset);
                     Offset = Offset + 25;
                     graphics.DrawString("Staying Time: " +user.getStayinTime(), font, brush, startX, startY + Offset);
                     Offset = Offset + 25;
                     graphics.DrawString("Total Amount: " + user.getAmountToBePaid().ToString("#.##") + "$", font, brush, startX, startY + Offset);

                //barCode font and drow it 
                //font = new Font("IDAutomationHC39M Free Version", 20);
                Offset = Offset + 30;
                     //graphics.DrawString("Ticket No : " + this.ticketNo, font, brush, 250, startY + Offset);

                     Image imgBarcode = BarcodeLib.Barcode.DoEncode(BarcodeLib.TYPE.CODE128, this.user.vehicleNo+DateTime.Now.ToString(), true, Color.Black, Color.White, 600, 60);
                     graphics.DrawImage(imgBarcode, 20, startY + Offset);
                 }
                 catch (Exception ex) { MessageBox.Show("Error in printing " + ex.ToString()); }
             }

             public static implicit operator string(Reciept v)
             {
                 throw new NotImplementedException();
             }
         
    }
}
