using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya","Bilgi Mesajı", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya","Bilgi Mesajı", MessageBoxButtons.AbortRetryIgnore);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya", "Bilgi Mesajı", MessageBoxButtons.OKCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya", "Bilgi Mesajı", MessageBoxButtons.RetryCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya", "Bilgi Mesajı", MessageBoxButtons.YesNo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya", "Bilgi Mesajı", MessageBoxButtons.YesNoCancel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya","Bilgi Mesajı", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya", "Bilgi Mesajı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya", "Bilgi Mesajı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya", "Bilgi Mesajı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu dosyayı silmek istediğinize emin misiniz ?", "DosyaSil",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
                //MessageBox.Show("Dosya silindi.");
            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }
    }
}
