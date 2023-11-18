using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmYapma
{
    internal class ParaCek
    {

        internal static void yap()
        {
            double bakiye = 10000;
            Console.Write("Çekilecek Miktarı Girin:");
            double cekilecekMiktar = Convert.ToDouble (Console.ReadLine());


            if(cekilecekMiktar > 0 && cekilecekMiktar <= bakiye)
            {
                bakiye = bakiye - cekilecekMiktar;
                Console.Write("Para Çekme İşlemi Başarılı ==> Yeni Bakiyeniz: {0}", bakiye);
            }
            else
            {
                Console.WriteLine("Geçeriz miktar veya yetersiz bakiye , Lütfen tekrar deneyiniz!!");
            }
        }
    }
}
