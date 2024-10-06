using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CSharp_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen Şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}


            //int number;
            //Console.Write("Please enter a number: ");
            //number = int.Parse(Console.ReadLine());
            //if(number == 3)
            //{
            //    Console.WriteLine("number is correct");
            //}
            //else
            //{
            //    Console.WriteLine("number is false");
            //}

            //int exam1, exam2, exam3, average;

            //string result="Hata!";

            //Console.Write("Exam1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Exam2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Exam3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Average :" + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "CC";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "BB";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "BA";
            //}
            //if (average > 84)
            //{
            //    result = "AA";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir giriniz: ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa") 
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else 
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.Write("kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            //Console.Read();
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());


            //int result = number1 % number2;

            //Console.WriteLine("1.sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen Sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("sayi tektir");
            //}





            #endregion

            #region Char Değişkenler ile karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region Örnek Uygulama

            //Console.WriteLine("********* C# Eğitim Kampı Restoran*******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi:  ");
            //menuItem = Console.ReadLine();
            //Console.WriteLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Ana Yemekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("1-Fasulye Pilav");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Ana Yemekler-----------------");
            //    Console.WriteLine() ;

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Çorbalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Çorbalar-----------------");

            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("--------------Pizzalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-MArgarita");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Pizzalar-----------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("--------------İçecekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Meyvesuyu");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İçecekler-----------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("--------------Tatlılar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Kadayıf");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Tatlılar-----------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");

            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Agustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:
            //        Console.Write("Hatalı veri girişi");
            //        break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //number1= int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen işlem yapmak istediğiniz sembolü giriniz ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark : " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm : " + result);
            //        break;
            //}

            #endregion

            Console.Read();

        }
    }
}
