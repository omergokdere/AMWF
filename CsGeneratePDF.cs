using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsGeneratePDF
    {

        //This method is for generating the PDF.

        public static void PerformGenerate()
        {
            //Defining variable for font
            iTextSharp.text.Font normalFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font headerFont = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font reportTypeFont = FontFactory.GetFont("Arial", 15, iTextSharp.text.Font.NORMAL);

            //Creating a document for PDF
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("Generated.pdf", FileMode.Create));
            document.Open();

            //Creating Header
            Paragraph p1Header = new Paragraph("GENERATED REPORT FOR GE400\n", headerFont);
            p1Header.Alignment = Element.ALIGN_CENTER;
            document.Add(p1Header);


            //All of this "IF" condition is for header type.
            if (UsrConPDF.ucPDF.combo_Filter.Text == "All" || UsrConPDF.ucPDF.combo_Filter.Text == "")
            {
                Paragraph allPar = new Paragraph("ALL", reportTypeFont);
                allPar.Alignment = Element.ALIGN_CENTER;

                document.Add(allPar);

            }

            if (UsrConPDF.ucPDF.combo_Filter.Text == "student")
            {
                Paragraph allPar = new Paragraph("student: " + UsrConPDF.ucPDF.txt_Search.Text, reportTypeFont);
                allPar.Alignment = Element.ALIGN_CENTER;

                document.Add(allPar);

            }

            if (UsrConPDF.ucPDF.combo_Filter.Text == "Day")
            {
                Paragraph allPar = new Paragraph("For the date of: " + UsrConPDF.ucPDF.datePick_From.Value.ToShortDateString(), reportTypeFont);
                allPar.Alignment = Element.ALIGN_CENTER;

                document.Add(allPar);
            }

            if (UsrConPDF.ucPDF.combo_Filter.Text == "Week")
            {
                string from = UsrConPDF.ucPDF.datePick_From.Value.ToShortDateString();
                string to = UsrConPDF.ucPDF.datePick_To.Value.ToShortDateString();

                Paragraph allPar = new Paragraph("For the week of: " + from + " - " + to, reportTypeFont);
                allPar.Alignment = Element.ALIGN_CENTER;

                document.Add(allPar);

            }


            if (UsrConPDF.ucPDF.combo_Filter.Text == "Month")
            {

                Paragraph allPar = new Paragraph("For the month of: " + UsrConPDF.ucPDF.combo_MonthDistance.Text, reportTypeFont);
                allPar.Alignment = Element.ALIGN_CENTER;

                document.Add(allPar);

            }

            document.Add(new Chunk("\n"));



            //Defining column with of the table.
            float[] columnWidths = { 2, 3, 2, 2, 2 };



            //Collecting all dates has attendance
            List<string> dateList = new List<string>();

            for (int i = 0; i < UsrConPDF.ucPDF.lv_User.Items.Count; i++)
            {
                string listDate = UsrConPDF.ucPDF.lv_User.Items[i].SubItems[5].Text;

                if (!dateList.Contains(listDate))
                {
                    dateList.Add(listDate);
                }
            }


            //Adding table and data to the PDF
            for (int i = 0; i < dateList.Count; i++)
            {

                PdfPTable table = new PdfPTable(columnWidths);
                table.HeaderRows = 1;

                Paragraph dateValue = new Paragraph("                     Date:  " + dateList[i] + "\n\n", normalFont);
                dateValue.Alignment = Element.ALIGN_LEFT;
                document.Add(dateValue);

                //Setting table header
                table.AddCell(new Phrase("Student ID", normalFont));
                table.AddCell(new Phrase("Name", normalFont));
                table.AddCell(new Phrase("Designation", normalFont));
                table.AddCell(new Phrase("Time-In", normalFont));
                table.AddCell(new Phrase("Time-Out", normalFont));


                //adding table data
                for (int listDataIndex = 0; listDataIndex < UsrConPDF.ucPDF.lv_User.Items.Count; listDataIndex++)
                {

                    if (UsrConPDF.ucPDF.lv_User.Items[listDataIndex].SubItems[5].Text == dateList[i])
                    {
                        string studentID = UsrConPDF.ucPDF.lv_User.Items[listDataIndex].SubItems[0].Text;
                        string studentName = UsrConPDF.ucPDF.lv_User.Items[listDataIndex].SubItems[1].Text;
                        string designation = UsrConPDF.ucPDF.lv_User.Items[listDataIndex].SubItems[2].Text;
                        string timeIn = UsrConPDF.ucPDF.lv_User.Items[listDataIndex].SubItems[3].Text;
                        string timeOut = UsrConPDF.ucPDF.lv_User.Items[listDataIndex].SubItems[4].Text;


                        table.AddCell(new Phrase(studentID, normalFont));
                        table.AddCell(new Phrase(studentName, normalFont));
                        table.AddCell(new Phrase(designation, normalFont));
                        table.AddCell(new Phrase(timeIn, normalFont));
                        table.AddCell(new Phrase(timeOut, normalFont));
                    }
                }


                document.Add(table);

                document.Add(new Chunk("\n"));
            }


            CsMessageBox.Show("Message: PDF is successfully generated!", CsMessageBox.OK, "Success");
            document.Close();
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Generated.pdf");
        }
    }
}
