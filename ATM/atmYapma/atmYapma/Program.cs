using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmYapma
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            while (true)
            {
                double bakiye = 10000;
                Console.WriteLine("XX BANK " );
                Console.WriteLine("*********************************************");
                Console.WriteLine("1. Para Çekme ");
                Console.WriteLine("2. Para Yatır ");
                Console.WriteLine("3. Bakiye Sorgulama ");
                Console.WriteLine("4. Çıkış ");
                Console.WriteLine("*********************************************");


                Console.Write("Hangi İşlemi yapacaksınız:");
                int islem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*********************************************");


                switch (islem)
                {
                    case 1:
                        ParaCek.yap();
                        break;
                     case 2:
                        ParaYatir.yatir();
                        break;
                    case 3:
                        BakiyeSorgula.sorgula();
                        break;
                    case 4:
                        Environment.Exit();
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem");
                        break;

                        

                }

                Console.ReadLine();

            }
        }
    }
}
