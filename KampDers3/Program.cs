using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampDers3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifre giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //--------------------------------------------------------------------
            //string capital, country;
            //Console.Write("Şehri giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Bilgiler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Bilgiler hatalı");
            //}
            //--------------------------------------------------------------------
            //int number;
            //Console.Write("Sayı giriniz:");
            //number=int.Parse(Console.ReadLine());

            //if (number == 3)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}
            //--------------------------------------------------------------------
            //int exam1, exam2, exam3, average;
            //string result="Sınav Notu Hatalı";
            //Console.WriteLine("***** SINAV NOTU HESAPLAMA *****");
            //Console.Write("1. Sınav Notunu Giriniz:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz:");
            //exam2=int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz:");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav not ortalaması:" + average);

            //if (average > 0 & average <= 49)
            //{
            //    result="Durumu Vasatt";
            //}
            //if (average>49 & average<=69)
            //{
            //    result="Durumu Orta";
            //}
            //if(average>69 & average <= 84)
            //{
            //    result = "Durumu İyii";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Durumu Çok İyii";
            //}
            //Console.WriteLine(result);
            //--------------------------------------------------------------------
            //string city;
            //Console.Write("Lütfen Şehir Giriniz:");
            //city = Console.ReadLine();

            //if (city == "düzce" | city == "ankara" | city == "istanbul")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}
            //--------------------------------------------------------------------
            //Console.Write("Kullanıcı adınızı giriniz:");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Lütfen geçerli kullanıcı adı giriniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Yönetici olarak giriş yaptınız :)");
            //}


            #endregion

            #region Mod Alma İşlemleri
            //Console.Write("Lütfen 1.sayıyı giriniz:");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz:");
            //int number2=int.Parse(Console.ReadLine());

            //int result =number1 % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan:"+result);

            //----------------------------------------------------------------------------
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Uygulama
            //Console.WriteLine("***** Lynch Restorant Menu *****");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------------");

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü numarasını yazınız: ");
            //menuItem = Console.ReadLine();
            //Console.WriteLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("------- Ana Yemekler -------");
            //    Console.WriteLine("1-Izgara Tavuk Göğsü");
            //    Console.WriteLine("2-Karnıyarık");
            //    Console.WriteLine("3-Fırında Levrek");
            //    Console.WriteLine("4-Mantı");
            //    Console.WriteLine("5-Dana İncik");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("------- Çorbalar -------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Tarhana Çorbası");
            //    Console.WriteLine("3-Domates Çorbası");
            //    Console.WriteLine("4-Ezogelin Çorbası");
            //    Console.WriteLine("5-Tavuk Suyu Çorbası");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("------- Pizzalar -------");
            //    Console.WriteLine("1-Margarita Pizza");
            //    Console.WriteLine("2-Pepperoni Pizza");
            //    Console.WriteLine("3-Dört Peynirli Pizza");
            //    Console.WriteLine("4-Sebzeli Pizza");
            //    Console.WriteLine("5-Barbekü Tavuklu Pizza");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("------- İçecekler -------");
            //    Console.WriteLine("1-Limonata");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Buzlu Çay");
            //    Console.WriteLine("4-Smoothie");
            //    Console.WriteLine("5-Nar Suyu");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("------- Tatlılar -------");
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Tiramisu");
            //    Console.WriteLine("4-Künefe");
            //    Console.WriteLine("5-Profiterol");
            //}

            #endregion

            #region Switch Case
            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthnumber=int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi!"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi
            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı Giriniz: ");
            number1 =int.Parse(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            symbol=char.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            switch (symbol)
            {
                
                case '+': result = number1 + number2;
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Sonuç: "+result); break;

                case '-': result = number1 - number2;
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Sonuç: "+result); break;

                case '/': result = number1 / number2;
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Sonuç: "+result); break;

                case '*': result = number1 * number2;
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Sonuç: "+result); break;


            }


            #endregion
            Console.Read();

        }
    }
}
