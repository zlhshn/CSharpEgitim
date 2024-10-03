using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharp_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.Write("Hello World!");
            //Console.WriteLine("Selam");
            //YAzdırma komutları

            //Console.WriteLine("*****Yemek Kategorileri***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Çorbalar");
            //Console.WriteLine("Salatalar");
            //Console.WriteLine("Tatlılar");
            //Console.WriteLine("İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategorileri***");
            #endregion

            #region StringDeğişkenler
            //string
            //Değiken_türü deişken_adı
            //string name;
            //name = "Zeliha";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 5000 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("****Rezervasyon Kartı**********");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletisim" + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Demir";
            //customerPhone = "+90 5000 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletisim" + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------");


            #endregion

            #region Int Değişkenler

            // int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;

            Console.WriteLine("*******Restoran menü********");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Coke: " + cokePrice + "TL");
            Console.WriteLine("-----Water: " + waterPrice + "TL");
            Console.WriteLine("-----Fries: " + friesPrice + "TL");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;


            int totalHamburgerPrices = hamburgerCount * hamburgerPrice;
            int totalCokePrices = cokeCount * cokeCount;
            int totalWaterPrices = waterPrice * waterPrice;
            int totalFriesPrices = friesPrice * friesPrice;

            Console.WriteLine("-----------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrices + "TL");
            Console.WriteLine("Coke Tutarı: " + totalCokePrices + "TL");
            Console.WriteLine("Water Tutarı: " + totalWaterPrices + "TL");
            Console.WriteLine("Fries Tutarı: " + totalFriesPrices + "TL");


            int totalPrices = totalHamburgerPrices + totalFriesPrices + totalCokePrices;

            Console.WriteLine(totalPrices);



           #endregion

            Console.Read();
        }
    }
}


