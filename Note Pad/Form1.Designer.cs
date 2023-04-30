namespace Note_Pad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDuzen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRenk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYazi = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDüzen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTürkce = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGörünüm = new System.Windows.Forms.ToolStripMenuItem();
            this.menüYakinlastir = new System.Windows.Forms.ToolStripMenuItem();
            this.menüUzaklaştır = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmDuzen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(410, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 5;
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // cmDuzen
            // 
            this.cmDuzen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.kopyalaToolStripMenuItem});
            this.cmDuzen.Name = "contextMenuStrip1";
            this.cmDuzen.Size = new System.Drawing.Size(159, 70);
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(44, 20);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // menuRenk
            // 
            this.menuRenk.Name = "menuRenk";
            this.menuRenk.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuRenk.Size = new System.Drawing.Size(158, 22);
            this.menuRenk.Text = "Renk";
            this.menuRenk.Click += new System.EventHandler(this.menuRenk_Click);
            // 
            // menuYazi
            // 
            this.menuYazi.Name = "menuYazi";
            this.menuYazi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuYazi.Size = new System.Drawing.Size(158, 22);
            this.menuYazi.Text = "Yazı Tipi";
            this.menuYazi.Click += new System.EventHandler(this.menuYazi_Click);
            // 
            // menuYapistir
            // 
            this.menuYapistir.Name = "menuYapistir";
            this.menuYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuYapistir.Size = new System.Drawing.Size(158, 22);
            this.menuYapistir.Text = "Yapıştır";
            this.menuYapistir.Click += new System.EventHandler(this.menuYapistir_Click);
            // 
            // menuKes
            // 
            this.menuKes.Name = "menuKes";
            this.menuKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuKes.Size = new System.Drawing.Size(158, 22);
            this.menuKes.Text = "Kes";
            this.menuKes.Click += new System.EventHandler(this.menuKes_Click);
            // 
            // menuDüzen
            // 
            this.menuDüzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKes,
            this.menuKopyala,
            this.menuYapistir,
            this.menuYazi,
            this.menuRenk,
            this.menuDil,
            this.menuGörünüm});
            this.menuDüzen.Name = "menuDüzen";
            this.menuDüzen.Size = new System.Drawing.Size(52, 20);
            this.menuDüzen.Text = "Düzen";
            // 
            // menuKopyala
            // 
            this.menuKopyala.Name = "menuKopyala";
            this.menuKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuKopyala.Size = new System.Drawing.Size(158, 22);
            this.menuKopyala.Text = "Kopyala";
            this.menuKopyala.Click += new System.EventHandler(this.menuKopyala_Click);
            // 
            // menuDil
            // 
            this.menuDil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTürkce,
            this.menuEnglish});
            this.menuDil.Name = "menuDil";
            this.menuDil.Size = new System.Drawing.Size(158, 22);
            this.menuDil.Text = "Dil";
            // 
            // menuTürkce
            // 
            this.menuTürkce.Name = "menuTürkce";
            this.menuTürkce.Size = new System.Drawing.Size(115, 22);
            this.menuTürkce.Text = "Türkçe";
            this.menuTürkce.Click += new System.EventHandler(this.menuTürkce_Click);
            // 
            // menuEnglish
            // 
            this.menuEnglish.Name = "menuEnglish";
            this.menuEnglish.Size = new System.Drawing.Size(115, 22);
            this.menuEnglish.Text = "English ";
            this.menuEnglish.Click += new System.EventHandler(this.menuEnglish_Click);
            // 
            // menuGörünüm
            // 
            this.menuGörünüm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüYakinlastir,
            this.menüUzaklaştır});
            this.menuGörünüm.Name = "menuGörünüm";
            this.menuGörünüm.Size = new System.Drawing.Size(158, 22);
            this.menuGörünüm.Text = "Görünüm";
            // 
            // menüYakinlastir
            // 
            this.menüYakinlastir.Name = "menüYakinlastir";
            this.menüYakinlastir.Size = new System.Drawing.Size(127, 22);
            this.menüYakinlastir.Text = "Yakınlaştır";
            this.menüYakinlastir.Click += new System.EventHandler(this.menüYakinlastir_Click);
            // 
            // menüUzaklaştır
            // 
            this.menüUzaklaştır.Name = "menüUzaklaştır";
            this.menüUzaklaştır.Size = new System.Drawing.Size(127, 22);
            this.menüUzaklaştır.Text = "Uzaklaştır";
            this.menüUzaklaştır.Click += new System.EventHandler(this.uzaklaştırToolStripMenuItem_Click);
            // 
            // menuYazdir
            // 
            this.menuYazdir.Name = "menuYazdir";
            this.menuYazdir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuYazdir.Size = new System.Drawing.Size(150, 22);
            this.menuYazdir.Text = "Yazdır";
            this.menuYazdir.Click += new System.EventHandler(this.menuYazdir_Click);
            // 
            // menuKaydet
            // 
            this.menuKaydet.Name = "menuKaydet";
            this.menuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuKaydet.Size = new System.Drawing.Size(150, 22);
            this.menuKaydet.Text = "Kaydet";
            this.menuKaydet.Click += new System.EventHandler(this.menuKaydet_Click);
            // 
            // menuAc
            // 
            this.menuAc.Name = "menuAc";
            this.menuAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuAc.Size = new System.Drawing.Size(150, 22);
            this.menuAc.Text = "Aç";
            this.menuAc.Click += new System.EventHandler(this.menuAc_Click);
            // 
            // menuYeni
            // 
            this.menuYeni.Name = "menuYeni";
            this.menuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuYeni.Size = new System.Drawing.Size(150, 22);
            this.menuYeni.Text = "Yeni";
            this.menuYeni.Click += new System.EventHandler(this.menuYeni_Click);
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeni,
            this.menuAc,
            this.menuKaydet,
            this.menuYazdir});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDüzen,
            this.menuCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.cmDuzen;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditor.Location = new System.Drawing.Point(0, 27);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(800, 423);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Note Pad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmDuzen.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument belge;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmDuzen;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem menuRenk;
        private System.Windows.Forms.ToolStripMenuItem menuYazi;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuYapistir;
        private System.Windows.Forms.ToolStripMenuItem menuKes;
        private System.Windows.Forms.ToolStripMenuItem menuDüzen;
        private System.Windows.Forms.ToolStripMenuItem menuKopyala;
        private System.Windows.Forms.ToolStripMenuItem menuYazdir;
        private System.Windows.Forms.ToolStripMenuItem menuKaydet;
        private System.Windows.Forms.ToolStripMenuItem menuAc;
        private System.Windows.Forms.ToolStripMenuItem menuYeni;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ToolStripMenuItem menuDil;
        private System.Windows.Forms.ToolStripMenuItem menuTürkce;
        private System.Windows.Forms.ToolStripMenuItem menuEnglish;
        private System.Windows.Forms.ToolStripMenuItem menuGörünüm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüYakinlastir;
        private System.Windows.Forms.ToolStripMenuItem menüUzaklaştır;
    }
}

