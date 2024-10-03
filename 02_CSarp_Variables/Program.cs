using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CSarp_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişikenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("****Fİyat Listesi***");

            //double applePrice, orangePrice, potato, tomato;

            //applePrice = 14.50;
            //tomato = 2.6;
            //potato = 3.7;
            //orangePrice = 22.6;

            //Console.WriteLine("------Elma Birim Fiyatı------" + applePrice);
            //Console.WriteLine("------Elma Birim Fiyatı------" + orangePrice);
            //Console.WriteLine("------Elma Birim Fiyatı------" + potato);
            //Console.WriteLine("------Elma Birim Fiyatı------" + tomato);

            //double appleGram, orangeGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //potatoGram = 3.780;
            //tomatoGram = 2.666;

            //double totalPrice = (applePrice * appleGram) + (orangePrice * orangeGram) + (tomato * tomatoGram) + (potato * potatoGram);

            //Console.WriteLine(totalPrice);

            #endregion

            #region Char Değişkenler

            //ABCDEFG

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden veri girişleri string değişkenleri

            //Console.WriteLine("Hava Yolları Yolcu Bilgisi");

            //string customerName, customerCity, customerCountry;

            //Console.Write("Yolcu Adı: ");
            //customerName = Console.ReadLine();

            //Console.Write("City: ");
            //customerCity = Console.ReadLine();

            //Console.WriteLine("-----------------------");

            //Console.WriteLine("Yolcu :" + customerName + "," + "City :" + customerCity);




            #endregion

            #region Klavyeden Tam Sayı Girişleri Dönüşümleri

            // Klavyeden girişleri string olarak gelir dönüşüm yapmak gerekir.

            //int shoePrice, computerPrice, chairPrice;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 1200;

            //int shoeCount, computerCount, chairCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını girin: ");
            ////Parse dönüşüm yapmak için kullanılır. int aralıkları var 32 bit aralığında veri girişi kabl edilecek bellekte kapladığı alan için
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını girin: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını girin : ");
            //chairCount = int.Parse(Console.ReadLine());

            //int totalPrice  = shoeCount* shoePrice + computerCount* computerPrice + chairCount* chairPrice;
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 3. sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Toplam Ortalama:" + result);
            #endregion

            #region Klavyeden Karakter Girişler

            //char gender;

            //Console.Write("Lütfen Cinsiyetinizi karakter olarak giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion


            Console.Read();
        }
    }
}