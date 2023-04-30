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
using System.Collections;

namespace Note_Pad
{
    public partial class Form1 : Form
    {
        string adi;
        string dil = "tr";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = adi;
        }

        private void menuKes_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void menuKopyala_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void menuYapistir_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            if (dil == "tr")
            {
                DialogResult cevap = MessageBox.Show("Gerçekten Çıkmak İstiyormusun ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cevap == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            if(dil=="eng")
            {
                DialogResult cevap = MessageBox.Show("Do you want to exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cevap == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void menuYeni_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void menuKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Dosyası |*.txt| Tüm Dosyalar |*.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyaları |*.txt";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult cevap = pd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                belge.Print();
            }
        }
        private void belge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtEditor.Text, txtEditor.Font, Brushes.Black, new Point(100, 100));
        }
        private void menuCikis_MouseHover(object sender, EventArgs e)
        {
            menuCikis.BackColor = Color.Red;
        }

        private void menuRenk_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtEditor.SelectionColor = cd.Color;
            }
        }
        private void menuYazi_Click_1(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fd.Font;
            }
        }
        private void menuYazi_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fd.Font;
            }
        }
        private void menuRenk_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtEditor.SelectionColor = cd.Color;
            }
        }

        private void menuEnglish_Click(object sender, EventArgs e)
        {
            menuDosya.Text = "File";
            menuYeni.Text = "New";
            menuAc.Text = "Open";
            menuKaydet.Text = "Save";
            menuYazdir.Text = "Print";
            menuDüzen.Text = "Order";
            menuKes.Text = "Cut";
            menuKopyala.Text = "Copy";
            menuYapistir.Text = "Paste";
            menuYazi.Text = "Font";
            menuRenk.Text = "Color";
            menuDil.Text = "Language";
            menuCikis.Text = "Exit";
            menuGörünüm.Text = "Appearance";
            menüYakinlastir.Text = "Zoom In";
            menüUzaklaştır.Text = "Zoom Out";
            dil = "eng";
        }

        private void menuTürkce_Click(object sender, EventArgs e)
        {
            menuDosya.Text = "Dosya";
            menuYeni.Text = "Yeni";
            menuAc.Text = "Aç";
            menuKaydet.Text = "Kaydet";
            menuYazdir.Text = "Yazdır";
            menuDüzen.Text = "Düzen";
            menuKes.Text = "Kes";
            menuKopyala.Text = "Kopyala";
            menuYapistir.Text = "Yapıştır";
            menuYazi.Text = "Yazi Tipi";
            menuRenk.Text = "Renk";
            menuDil.Text = "Dil";
            menuCikis.Text = "Çıkış";
            menuGörünüm.Text = "Görünüm";
            menüYakinlastir.Text = "Yakınlaştır";
            menüUzaklaştır.Text = "Uzaklaştır";
            dil = "tr";
        }

        private void menüYakinlastir_Click(object sender, EventArgs e)
        {
            txtEditor.ZoomFactor += 0.2f;
        }

        private void uzaklaştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.ZoomFactor -= 0.2f;
        }
    }
}
