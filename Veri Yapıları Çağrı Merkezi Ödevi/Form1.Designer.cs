﻿namespace Veri_Yapıları_Çağrı_Merkezi_Ödevi
{
    partial class cagriMerkezi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCagri = new System.Windows.Forms.TabControl();
            this.musteriGiris = new System.Windows.Forms.TabPage();
            this.cagriAtama = new System.Windows.Forms.TabPage();
            this.aramaSiralama = new System.Windows.Forms.TabPage();
            this.kayitlariGoster = new System.Windows.Forms.TabPage();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.lblMusteriTipi = new System.Windows.Forms.Label();
            this.btnAramaYap = new System.Windows.Forms.Button();
            this.btnCagriBitir = new System.Windows.Forms.Button();
            this.btnSiradakiCagri = new System.Windows.Forms.Button();
            this.lblCagriID = new System.Windows.Forms.Label();
            this.txtCagriID = new System.Windows.Forms.TextBox();
            this.btnCagriyiAta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotAra = new System.Windows.Forms.Label();
            this.txtNotAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.rtxtArama = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtxtSiralama = new System.Windows.Forms.RichTextBox();
            this.lblBMusteriSirasi = new System.Windows.Forms.Label();
            this.rtxtBMusteriSirasi = new System.Windows.Forms.RichTextBox();
            this.rtxtTMusteriSirasi = new System.Windows.Forms.RichTextBox();
            this.lblTMusteriSirasi = new System.Windows.Forms.Label();
            this.lblKayitEkrani = new System.Windows.Forms.Label();
            this.rtxtKayitEkrani = new System.Windows.Forms.RichTextBox();
            this.rBtnTicari = new System.Windows.Forms.RadioButton();
            this.rBtnBireysel = new System.Windows.Forms.RadioButton();
            this.tabCagri.SuspendLayout();
            this.musteriGiris.SuspendLayout();
            this.cagriAtama.SuspendLayout();
            this.aramaSiralama.SuspendLayout();
            this.kayitlariGoster.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCagri
            // 
            this.tabCagri.Controls.Add(this.musteriGiris);
            this.tabCagri.Controls.Add(this.cagriAtama);
            this.tabCagri.Controls.Add(this.aramaSiralama);
            this.tabCagri.Controls.Add(this.kayitlariGoster);
            this.tabCagri.Location = new System.Drawing.Point(12, 12);
            this.tabCagri.Name = "tabCagri";
            this.tabCagri.SelectedIndex = 0;
            this.tabCagri.Size = new System.Drawing.Size(570, 413);
            this.tabCagri.TabIndex = 0;
            // 
            // musteriGiris
            // 
            this.musteriGiris.Controls.Add(this.rBtnBireysel);
            this.musteriGiris.Controls.Add(this.rBtnTicari);
            this.musteriGiris.Controls.Add(this.btnAramaYap);
            this.musteriGiris.Controls.Add(this.lblMusteriTipi);
            this.musteriGiris.Controls.Add(this.txtMusteriID);
            this.musteriGiris.Controls.Add(this.lblMusteriID);
            this.musteriGiris.Location = new System.Drawing.Point(4, 22);
            this.musteriGiris.Name = "musteriGiris";
            this.musteriGiris.Padding = new System.Windows.Forms.Padding(3);
            this.musteriGiris.Size = new System.Drawing.Size(562, 387);
            this.musteriGiris.TabIndex = 0;
            this.musteriGiris.Text = "Müşteri Giriş";
            this.musteriGiris.UseVisualStyleBackColor = true;
            // 
            // cagriAtama
            // 
            this.cagriAtama.Controls.Add(this.label1);
            this.cagriAtama.Controls.Add(this.btnCagriyiAta);
            this.cagriAtama.Controls.Add(this.txtCagriID);
            this.cagriAtama.Controls.Add(this.lblCagriID);
            this.cagriAtama.Controls.Add(this.btnSiradakiCagri);
            this.cagriAtama.Controls.Add(this.btnCagriBitir);
            this.cagriAtama.Location = new System.Drawing.Point(4, 22);
            this.cagriAtama.Name = "cagriAtama";
            this.cagriAtama.Padding = new System.Windows.Forms.Padding(3);
            this.cagriAtama.Size = new System.Drawing.Size(562, 387);
            this.cagriAtama.TabIndex = 1;
            this.cagriAtama.Text = "Çağrı Atama";
            this.cagriAtama.UseVisualStyleBackColor = true;
            // 
            // aramaSiralama
            // 
            this.aramaSiralama.Controls.Add(this.rtxtSiralama);
            this.aramaSiralama.Controls.Add(this.button1);
            this.aramaSiralama.Controls.Add(this.rtxtArama);
            this.aramaSiralama.Controls.Add(this.btnAra);
            this.aramaSiralama.Controls.Add(this.txtNotAra);
            this.aramaSiralama.Controls.Add(this.lblNotAra);
            this.aramaSiralama.Location = new System.Drawing.Point(4, 22);
            this.aramaSiralama.Name = "aramaSiralama";
            this.aramaSiralama.Padding = new System.Windows.Forms.Padding(3);
            this.aramaSiralama.Size = new System.Drawing.Size(562, 387);
            this.aramaSiralama.TabIndex = 2;
            this.aramaSiralama.Text = "Arama / Sıralama";
            this.aramaSiralama.UseVisualStyleBackColor = true;
            // 
            // kayitlariGoster
            // 
            this.kayitlariGoster.Controls.Add(this.rtxtKayitEkrani);
            this.kayitlariGoster.Controls.Add(this.lblKayitEkrani);
            this.kayitlariGoster.Controls.Add(this.rtxtTMusteriSirasi);
            this.kayitlariGoster.Controls.Add(this.lblTMusteriSirasi);
            this.kayitlariGoster.Controls.Add(this.rtxtBMusteriSirasi);
            this.kayitlariGoster.Controls.Add(this.lblBMusteriSirasi);
            this.kayitlariGoster.Location = new System.Drawing.Point(4, 22);
            this.kayitlariGoster.Name = "kayitlariGoster";
            this.kayitlariGoster.Padding = new System.Windows.Forms.Padding(3);
            this.kayitlariGoster.Size = new System.Drawing.Size(562, 387);
            this.kayitlariGoster.TabIndex = 3;
            this.kayitlariGoster.Text = "Kayıtları Göster";
            this.kayitlariGoster.UseVisualStyleBackColor = true;
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(152, 101);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(55, 13);
            this.lblMusteriID.TabIndex = 0;
            this.lblMusteriID.Text = "Müşteri ID";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(213, 98);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(99, 20);
            this.txtMusteriID.TabIndex = 1;
            // 
            // lblMusteriTipi
            // 
            this.lblMusteriTipi.AutoSize = true;
            this.lblMusteriTipi.Location = new System.Drawing.Point(146, 144);
            this.lblMusteriTipi.Name = "lblMusteriTipi";
            this.lblMusteriTipi.Size = new System.Drawing.Size(61, 13);
            this.lblMusteriTipi.TabIndex = 2;
            this.lblMusteriTipi.Text = "Müşteri Tipi";
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.Location = new System.Drawing.Point(256, 181);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(75, 23);
            this.btnAramaYap.TabIndex = 5;
            this.btnAramaYap.Text = "Arama Yap";
            this.btnAramaYap.UseVisualStyleBackColor = true;
            // 
            // btnCagriBitir
            // 
            this.btnCagriBitir.Location = new System.Drawing.Point(453, 319);
            this.btnCagriBitir.Name = "btnCagriBitir";
            this.btnCagriBitir.Size = new System.Drawing.Size(75, 23);
            this.btnCagriBitir.TabIndex = 1;
            this.btnCagriBitir.Text = "Çağrıyı Bitir";
            this.btnCagriBitir.UseVisualStyleBackColor = true;
            // 
            // btnSiradakiCagri
            // 
            this.btnSiradakiCagri.Location = new System.Drawing.Point(187, 53);
            this.btnSiradakiCagri.Name = "btnSiradakiCagri";
            this.btnSiradakiCagri.Size = new System.Drawing.Size(138, 23);
            this.btnSiradakiCagri.TabIndex = 2;
            this.btnSiradakiCagri.Text = "Sıradaki Çağrıyı Ata";
            this.btnSiradakiCagri.UseVisualStyleBackColor = true;
            // 
            // lblCagriID
            // 
            this.lblCagriID.AutoSize = true;
            this.lblCagriID.Location = new System.Drawing.Point(150, 201);
            this.lblCagriID.Name = "lblCagriID";
            this.lblCagriID.Size = new System.Drawing.Size(69, 13);
            this.lblCagriID.TabIndex = 3;
            this.lblCagriID.Text = "Çağrı ID Girin";
            // 
            // txtCagriID
            // 
            this.txtCagriID.Location = new System.Drawing.Point(225, 198);
            this.txtCagriID.Name = "txtCagriID";
            this.txtCagriID.Size = new System.Drawing.Size(100, 20);
            this.txtCagriID.TabIndex = 4;
            // 
            // btnCagriyiAta
            // 
            this.btnCagriyiAta.Location = new System.Drawing.Point(225, 233);
            this.btnCagriyiAta.Name = "btnCagriyiAta";
            this.btnCagriyiAta.Size = new System.Drawing.Size(99, 23);
            this.btnCagriyiAta.TabIndex = 5;
            this.btnCagriyiAta.Text = "Çağrıyı Ata";
            this.btnCagriyiAta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------";
            // 
            // lblNotAra
            // 
            this.lblNotAra.AutoSize = true;
            this.lblNotAra.Location = new System.Drawing.Point(79, 65);
            this.lblNotAra.Name = "lblNotAra";
            this.lblNotAra.Size = new System.Drawing.Size(43, 13);
            this.lblNotAra.TabIndex = 0;
            this.lblNotAra.Text = "Not Ara";
            // 
            // txtNotAra
            // 
            this.txtNotAra.Location = new System.Drawing.Point(128, 62);
            this.txtNotAra.Name = "txtNotAra";
            this.txtNotAra.Size = new System.Drawing.Size(100, 20);
            this.txtNotAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(153, 98);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // rtxtArama
            // 
            this.rtxtArama.Enabled = false;
            this.rtxtArama.Location = new System.Drawing.Point(259, 6);
            this.rtxtArama.Name = "rtxtArama";
            this.rtxtArama.ReadOnly = true;
            this.rtxtArama.Size = new System.Drawing.Size(297, 198);
            this.rtxtArama.TabIndex = 3;
            this.rtxtArama.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Günlük Toplam Aramaları Sırala";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rtxtSiralama
            // 
            this.rtxtSiralama.Enabled = false;
            this.rtxtSiralama.Location = new System.Drawing.Point(259, 210);
            this.rtxtSiralama.Name = "rtxtSiralama";
            this.rtxtSiralama.ReadOnly = true;
            this.rtxtSiralama.Size = new System.Drawing.Size(297, 170);
            this.rtxtSiralama.TabIndex = 5;
            this.rtxtSiralama.Text = "";
            // 
            // lblBMusteriSirasi
            // 
            this.lblBMusteriSirasi.AutoSize = true;
            this.lblBMusteriSirasi.Location = new System.Drawing.Point(6, 14);
            this.lblBMusteriSirasi.Name = "lblBMusteriSirasi";
            this.lblBMusteriSirasi.Size = new System.Drawing.Size(108, 13);
            this.lblBMusteriSirasi.TabIndex = 0;
            this.lblBMusteriSirasi.Text = "Bireysel Müşteri Sırası";
            // 
            // rtxtBMusteriSirasi
            // 
            this.rtxtBMusteriSirasi.Enabled = false;
            this.rtxtBMusteriSirasi.Location = new System.Drawing.Point(6, 30);
            this.rtxtBMusteriSirasi.Name = "rtxtBMusteriSirasi";
            this.rtxtBMusteriSirasi.Size = new System.Drawing.Size(550, 56);
            this.rtxtBMusteriSirasi.TabIndex = 1;
            this.rtxtBMusteriSirasi.Text = "";
            // 
            // rtxtTMusteriSirasi
            // 
            this.rtxtTMusteriSirasi.Enabled = false;
            this.rtxtTMusteriSirasi.Location = new System.Drawing.Point(3, 117);
            this.rtxtTMusteriSirasi.Name = "rtxtTMusteriSirasi";
            this.rtxtTMusteriSirasi.Size = new System.Drawing.Size(553, 56);
            this.rtxtTMusteriSirasi.TabIndex = 3;
            this.rtxtTMusteriSirasi.Text = "";
            // 
            // lblTMusteriSirasi
            // 
            this.lblTMusteriSirasi.AutoSize = true;
            this.lblTMusteriSirasi.Location = new System.Drawing.Point(3, 101);
            this.lblTMusteriSirasi.Name = "lblTMusteriSirasi";
            this.lblTMusteriSirasi.Size = new System.Drawing.Size(98, 13);
            this.lblTMusteriSirasi.TabIndex = 2;
            this.lblTMusteriSirasi.Text = "Ticari Müşteri Sırası";
            // 
            // lblKayitEkrani
            // 
            this.lblKayitEkrani.AutoSize = true;
            this.lblKayitEkrani.Location = new System.Drawing.Point(0, 185);
            this.lblKayitEkrani.Name = "lblKayitEkrani";
            this.lblKayitEkrani.Size = new System.Drawing.Size(63, 13);
            this.lblKayitEkrani.TabIndex = 4;
            this.lblKayitEkrani.Text = "Kayıt Ekranı";
            // 
            // rtxtKayitEkrani
            // 
            this.rtxtKayitEkrani.Enabled = false;
            this.rtxtKayitEkrani.Location = new System.Drawing.Point(0, 201);
            this.rtxtKayitEkrani.Name = "rtxtKayitEkrani";
            this.rtxtKayitEkrani.Size = new System.Drawing.Size(556, 180);
            this.rtxtKayitEkrani.TabIndex = 5;
            this.rtxtKayitEkrani.Text = "";
            // 
            // rBtnTicari
            // 
            this.rBtnTicari.AutoSize = true;
            this.rBtnTicari.Location = new System.Drawing.Point(213, 142);
            this.rBtnTicari.Name = "rBtnTicari";
            this.rBtnTicari.Size = new System.Drawing.Size(51, 17);
            this.rBtnTicari.TabIndex = 6;
            this.rBtnTicari.TabStop = true;
            this.rBtnTicari.Text = "Ticari";
            this.rBtnTicari.UseVisualStyleBackColor = true;
            // 
            // rBtnBireysel
            // 
            this.rBtnBireysel.AutoSize = true;
            this.rBtnBireysel.Location = new System.Drawing.Point(270, 142);
            this.rBtnBireysel.Name = "rBtnBireysel";
            this.rBtnBireysel.Size = new System.Drawing.Size(61, 17);
            this.rBtnBireysel.TabIndex = 7;
            this.rBtnBireysel.TabStop = true;
            this.rBtnBireysel.Text = "Bireysel";
            this.rBtnBireysel.UseVisualStyleBackColor = true;
            // 
            // cagriMerkezi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 426);
            this.Controls.Add(this.tabCagri);
            this.Name = "cagriMerkezi";
            this.Text = "Çağrı Merkezi";
            this.tabCagri.ResumeLayout(false);
            this.musteriGiris.ResumeLayout(false);
            this.musteriGiris.PerformLayout();
            this.cagriAtama.ResumeLayout(false);
            this.cagriAtama.PerformLayout();
            this.aramaSiralama.ResumeLayout(false);
            this.aramaSiralama.PerformLayout();
            this.kayitlariGoster.ResumeLayout(false);
            this.kayitlariGoster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCagri;
        private System.Windows.Forms.TabPage musteriGiris;
        private System.Windows.Forms.TabPage cagriAtama;
        private System.Windows.Forms.TabPage aramaSiralama;
        private System.Windows.Forms.TabPage kayitlariGoster;
        private System.Windows.Forms.Label lblMusteriTipi;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Button btnAramaYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCagriyiAta;
        private System.Windows.Forms.TextBox txtCagriID;
        private System.Windows.Forms.Label lblCagriID;
        private System.Windows.Forms.Button btnSiradakiCagri;
        private System.Windows.Forms.Button btnCagriBitir;
        private System.Windows.Forms.RichTextBox rtxtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtNotAra;
        private System.Windows.Forms.Label lblNotAra;
        private System.Windows.Forms.RichTextBox rtxtSiralama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxtKayitEkrani;
        private System.Windows.Forms.Label lblKayitEkrani;
        private System.Windows.Forms.RichTextBox rtxtTMusteriSirasi;
        private System.Windows.Forms.Label lblTMusteriSirasi;
        private System.Windows.Forms.RichTextBox rtxtBMusteriSirasi;
        private System.Windows.Forms.Label lblBMusteriSirasi;
        private System.Windows.Forms.RadioButton rBtnBireysel;
        private System.Windows.Forms.RadioButton rBtnTicari;
    }
}

