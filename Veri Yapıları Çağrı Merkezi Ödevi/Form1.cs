using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_Çağrı_Merkezi_Ödevi
{
    public partial class cagriMerkezi : Form
    {
        public cagriMerkezi()
        {
            InitializeComponent();
        }

        BireyselMusteriLinkedList BLL = new BireyselMusteriLinkedList();
        

       

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            int ID;
            Musteri bMusteri = new Musteri();
            ID = bMusteri.MusteriID = Convert.ToInt32(txtMusteriID.Text);
            BLL.basaEkle(ID);

            rtxtBMusteriSirasi.Text = BLL.yazdir();
            MessageBox.Show("Müşteri Türü: Bireysel"
                            + "\n" + BLL.SiradaArama(ID));
        }

        private void btnTicariArama_Click(object sender, EventArgs e)
        {
            int ID;
            Musteri tMusteri = new Musteri();
            ID = tMusteri.MusteriID = Convert.ToInt32(txtMusteriID.Text);
            BLL.basaEkle(ID);

            rtxtTMusteriSirasi.Text = BLL.yazdir();
            MessageBox.Show("Müşteri Türü: Ticari"
                            + "\n" + BLL.SiradaArama(ID));

            // Müşteri tipi ve sırasını messageBox ile göster
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            
        }
    }
}
