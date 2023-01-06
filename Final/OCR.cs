using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;

namespace Final
{
    public partial class OCR : Form
    {
        public OCR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a file dialog
            OpenFileDialog fileDialog = new OpenFileDialog();

            // Set filter options and filter index
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fileDialog.FilterIndex = 1;

            // Call the ShowDialog method to show the dialog
            DialogResult result = fileDialog.ShowDialog();

            // Process input if the user clicked OK
            if (result == DialogResult.OK)
            {
                // Open the selected file to read
                string file = fileDialog.FileName;
                // ...
                using (var objOcr = OcrApi.Create())
                {
                    objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                    string plainText = objOcr.GetTextFromImage(file);
                    textBox1.Text = plainText;
            }
            }


           
        }
    }
}
