using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - 100 arasındaki sayıları ekrana yazdıran program.
            byte sayac = 1;

            while (sayac <= 100)
            {
                Console.WriteLine(sayac);
                sayac++;
            }



            /*1 - 10 arasında rastgele üretilen sayıyı bulma oyunu:
             7 tahmin hakkı olsun.
             Her tahminde ipuçu olarak: Daha küçük veya daha büyük giriniz desin.
             */
            Random rastgele = new Random();
            int rastSayi = rastgele.Next(10);
            Console.Write("Tahmininiz:");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            while (tahmin != rastSayi)
            {
                Console.Write("Tahmininiz:");
                tahmin = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tebrikler Bildiniz");

            //Klavyeden Ç tuşuna basılana kadar: Ekrana "Smartpro" yazdıran program"
            while (true)
            {
                Console.WriteLine("Smartpro(çıkmak için: ç)");
                string harf = Console.ReadLine();
                if (harf.ToUpper() == "Ç")
                {
                    break;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                    // Buradan sonrası çalıştırılmadan;
                    // Bir sonraki döngüye geçer.
                    // break; döngüden direkt çıkar.
                }
                Console.WriteLine(i);
            }
            //5.ve 7.satırı atla. 10'da çık.
            for (int i = 1; i <= 15; i++)
            {
                if (i == 5 || i == 7)
                    continue; // atla
                if (i == 10)
                    break;    // bitir
                Console.WriteLine("Satır Numarası : " + i);
            }           
            for (int i = 1; i <= 30; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                    continue;
                }
                if (i == 28)
                {
                    break;
                }
                Console.WriteLine($"Sayı : {i}");
            }
            Console.Read();
        }
    }
}