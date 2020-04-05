using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFTools
{
    public partial class PDFToolsMainForm : Form
    {
        public string FileName;
        public string FilePath;
        public string OutputPath;
        public int Dpi;

        public PDFToolsMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            System.IO.FileInfo _fileInfo = new System.IO.FileInfo(openFileDialog1.FileName);

            FileName = _fileInfo.Name;
            FilePath = _fileInfo.FullName;
            InputTextBox.Text = FilePath;
        }

        private void PDFToolsMainForm_Load(object sender, EventArgs e)
        {
            ImageFormatComboBox.SelectedIndex = 0;
            Dpi = Convert.ToInt32(DpiBox.Value);
            openFileDialog1.Filter = "Все PDF Файлы | *.pdf";
        }

        private void OutputChooseButton_OnClick(object sender, EventArgs e)
        {
            if (OutputFolderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;

            OutputPath = OutputFolderBrowserDialog.SelectedPath;
            OutputTextBox.Text = OutputPath;
        }

        private void DpiBox_ValueChanged(object sender, EventArgs e)
        {
            Dpi = Convert.ToInt32(DpiBox.Value);
        }

        private void StartConvertationButton_Click(object sender, EventArgs e)
        {
            ToggleProgressBar();
            Thread _thread = new Thread(delegate () { Tools.Converter.FromPdfToImage(FilePath, FileName, OutputPath, Dpi, 1000000); });
            _thread.Start();
            MessageBox.Show("Мы начали конвертацию :)");

        }

        private bool isProgressBarToggled = false;
        public static void ToggleProgressBar()
        {
            PDFToolsMainForm mainForm = new PDFToolsMainForm();
            mainForm.isProgressBarToggled = !mainForm.isProgressBarToggled;

            if (mainForm.isProgressBarToggled == true)
            {
                mainForm.ProgressBar.MarqueeAnimationSpeed = 3;
            }
            else if (mainForm.isProgressBarToggled == false)
            {
                mainForm.ProgressBar.MarqueeAnimationSpeed = 0;
            }
        }
    }
}
