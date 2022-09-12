using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaseClass bazSinif = new BaseClass();
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            
            if (rdb_yonetim.Checked == true)
            {
                Yonetim yonetim = new Yonetim();
                yonetim.TecrubeYili = (int)nud_tucrubeYili.Value;
                yonetim.MaasKatsayisi = 13.4;
                
                if (dtp_tarihSecimi.Value.Year.ToString() != "2022")
                {
                    yonetim.MaasKatsayisi = bazSinif.MaasKatsayisiBelirle((double)nud_maasKatsayisi.Value);
                }
                
                txt_hesaplananMaas.Text = yonetim.MaasHesapla(yonetim.TecrubeYili, yonetim.MaasKatsayisi).ToString();
            }

            
            if (rdb_ogretmen.Checked == true)
            {
                Ogretmen ogretmen = new Ogretmen();
                ogretmen.TecrubeYili = (int)nud_tucrubeYili.Value;
                ogretmen.MaasKatsayisi = 13.4;

                if (dtp_tarihSecimi.Value.Year.ToString() != "2022")
                {
                    ogretmen.MaasKatsayisi = bazSinif.MaasKatsayisiBelirle((double)nud_maasKatsayisi.Value);
                }

                txt_hesaplananMaas.Text = ogretmen.MaasHesapla(ogretmen.TecrubeYili, ogretmen.MaasKatsayisi).ToString();
            }

            
            if (rdb_personel.Checked == true)
            {
                Personel personel = new Personel();
                personel.TecrubeYili = (int)nud_tucrubeYili.Value;
                personel.MaasKatsayisi = 13.4;

                if (dtp_tarihSecimi.Value.Year.ToString() != "2022")
                {
                    personel.MaasKatsayisi = bazSinif.MaasKatsayisiBelirle((double)nud_maasKatsayisi.Value);
                }

                txt_hesaplananMaas.Text = personel.MaasHesapla(personel.TecrubeYili, personel.MaasKatsayisi).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grp_maasKatsayi.Enabled = false;
        }


        private void dtp_tarihSecimi_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_tarihSecimi.Value.Year.ToString() == "2022")
            {
                grp_maasKatsayi.Enabled = false;
            }
            if (dtp_tarihSecimi.Value.Year.ToString() != "2022")
            {
                grp_maasKatsayi.Enabled = true;
            }
        }
    }
}
