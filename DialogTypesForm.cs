using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Dialog_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Dosyası | *.txt | Tüm Dosyalar | *.*";
                DialogResult cevap = sfd.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Dosyaları | *.txt";
                DialogResult cevap = ofd.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                PrintDialog pd = new PrintDialog();
                DialogResult cevap = pd.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {
                e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font,
                Brushes.Black, new Point(100, 100));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                FontDialog fd = new FontDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fd.Font;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = cd.Color;
                }
            }
        }
    }
}
