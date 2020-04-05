using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFTools.Tools
{
    class Converter
    {
        public static void FromPdfToImage(string InputFile, string OutputFileName, string OuputPath, int Dpi, int NumberMaxPage)
        {
            try
            {
                using (var doc = PdfDocument.Load(InputFile))
                {               // Load PDF Document from file
                    for (int _page = 0; _page < doc.PageCount && _page < NumberMaxPage; _page++)
                    {          // Loop through pages
                        using (var img = doc.Render(_page, Dpi, Dpi, false))
                        {   // Render with dpi and with forPrinting false
                            img.Save(OuputPath + "\\" + $"page_{_page}_{OutputFileName}" + ".jpg");     // Save rendered image to disc
                        }
                    }
                }

                PDFTools.PDFToolsMainForm.ToggleProgressBar();
                MessageBox.Show("Конвертация успешна завершена");
            }
            catch
            {
                MessageBox.Show("Ошибка конвертации");
            }
        }
    }
}
