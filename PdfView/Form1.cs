using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.IO;

namespace PdfView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName);
            }
        }

        private void openFile(string fileName)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(fileName);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfdocument = PdfDocument.Load(stream);
            pdfViewer1.Document = pdfdocument;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
