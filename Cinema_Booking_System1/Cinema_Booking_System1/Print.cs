using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Cinema_Booking_System1
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintBill(); // Printing the bill
        }

        //Open Print Dialog To Print A Documents
        public void PrintBill()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(pdoc_PrintPage); // Setting the print to print the docments
            DialogResult result = printDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK) // if result ok print dialogs
                {

                    printDocument.Print();
                }
            }
            catch
            {
                MessageBox.Show("Printing has a problem!"); // A problem is in the printers
            }
        }

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // The Doumentt to be printed
            Graphics graphic = e.Graphics;
            Font font = new Font("Cambria", 12);
            float FontHeight = font.GetHeight();

            int startX = 17;
            int startY = 17;


            graphic.DrawString("Cinema Booking System \n", new Font("Cambria", 22), new SolidBrush(Color.Black), startX, startY);

            string strText = "This is a voucher, when you show it to the kiosk, you will get a free medium popcorn. From Keith Cutajar. Thank You for booking a ticket with us.";


            graphic.DrawString("\n" + strText, new Font("Cambria", 22), new SolidBrush(Color.Black), startX, startY);



        }



        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
