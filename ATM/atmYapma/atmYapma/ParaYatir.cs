using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmYapma
{
    internal class ParaYatir
    {
        internal static void yatir()
        {
            double bakiye = 10000;

            Console.Write("Yatırılacak Miktarı giriniz:");
            double yatirilanMiktar = Convert.ToDouble(Console.ReadLine());  

            if(yatirilanMiktar > 0)
            {
                bakiye += yatirilanMiktar;
                Console.Write("Para yatırma işlemi başarılı ==> Güncel bakiyeniz: {0}", bakiye);
            }
            else
            {
                Console.WriteLine("Geçersiz miktar.Lütfen pozitif bir miktar girin!!!");
            }
        }
    }
}
