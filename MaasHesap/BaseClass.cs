using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasHesap
{
    public class BaseClass
    {

        public string GununTarihi { get; set; }
        public int TecrubeYili { get; set; }
        public double MaasKatsayisi { get; set; }

        public virtual double MaasHesapla(int tecrubeYili, double maasKatsayisi)
        {
            double maas;
            int bazPuan = 400;

            for (int i = 1; i <= tecrubeYili; i++)
            {
                bazPuan = bazPuan + (int)(bazPuan * 0.02);
            }

            maas = bazPuan * maasKatsayisi;

            return maas;
        }

        public double MaasKatsayisiBelirle(double MaasKatsayisi)
        {
            this.MaasKatsayisi = MaasKatsayisi;
            return MaasKatsayisi;
        }
    }
}
