using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasHesap
{
    public class Yonetim : BaseClass
    {
        
        public override double MaasHesapla(int tecrubeYili, double maasKatsayisi)
        {
            double maas;
            int bazPuan = 1500;

            for (int i = 1; i <= tecrubeYili; i++)
            {
                bazPuan = bazPuan + (int)(bazPuan * 0.02);
            }

            maas = bazPuan * maasKatsayisi;

            return maas;
        }
    }
}

