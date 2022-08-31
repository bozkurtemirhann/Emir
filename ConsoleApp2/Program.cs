using System;
namespace ConsoleApp1
{
    public class Program
    {


        static void Main(string[] args)
        {
           // KM Sistemi. 
            
            Console.WriteLine("KM değer giriniz. ");
            int km;

            km = (Convert.ToInt32(Console.ReadLine()));

            double perKM = 2.20, total = 10;

            total += (perKM * km);

            total = (total < 20) ? 20 : total;

            Console.WriteLine("Toplam Tutar: " + total);
            Console.ReadKey();
        } 

    }
}

