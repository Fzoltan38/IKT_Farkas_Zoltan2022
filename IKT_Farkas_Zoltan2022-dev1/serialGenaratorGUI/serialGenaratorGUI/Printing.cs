using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialGenaratorGUI
{
    internal class Printing
    {
        public void doPdf(ListBox listForm1)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12, XFontStyle.Regular);
            
            //string line = null;

            int h = 0;
            foreach (var item in listForm1.Items)
            {     
                gfx.DrawString(item.ToString(), font, XBrushes.Black,
                new XRect(0, h, page.Width, page.Height), XStringFormats.TopLeft);
                h=h+12;

                /*if (line != null)
                {
                    ppeArgs.HasMorePages = true;
                }
                else
                {
                    ppeArgs.HasMorePages = false;
                }*/
            }

            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.DefaultExt = "pdf";
                dlg.Filter = "Pdf files (*.pdf)|*.pdf |Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dlg.ShowDialog();

                string filename = dlg.FileName;
                document.Save(filename);
                //Load PDF File for viewing
                Process.Start(filename);
            }
            catch { }
          

        }
    }
}
