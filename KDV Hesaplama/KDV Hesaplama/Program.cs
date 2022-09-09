using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // KDV Hesaplama
            double kdvoran = 0.18, kdvTutar, kdvLiTutar;
            Console.WriteLine("Ucret tutarını giriniz: ");
            double tutar = Convert.ToInt32(Console.ReadLine());


            kdvTutar = tutar * kdvoran;
            kdvLiTutar = tutar * kdvTutar;
            Console.WriteLine("KDVSİZ TUTAR: " + tutar);
            Console.WriteLine("KDV ORANI: " + kdvoran);
            Console.WriteLine("KDV TUTARI: " + kdvTutar);
            Console.WriteLine("KDVLİ TUTAR: " + kdvLiTutar);



            Console.ReadKey();
        }
    }
}