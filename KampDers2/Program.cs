using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampDers2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Double Değişkenler
			Console.OutputEncoding = Encoding.UTF8;//UTF 8 FORMATI İÇİN "₺" SİMGESİNİN EKRANDA GÖZÜKMESİNDE KULLANILDI
			Console.WriteLine("***** Fiyat Listesi *****");
			Console.WriteLine();
			double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
			applePrice = 23.41;
			orangePrice = 17.78;
			strawberryPrice = 30;
			patatoPrice = 10.50;
			tomatoPrice = 13.65;
			Console.WriteLine("--> Elma Kg: " + applePrice + "₺");
			Console.WriteLine("--> Portakal Kg: " + orangePrice + "₺");
			Console.WriteLine("--> Çilek Kg: " + strawberryPrice + "₺");
			Console.WriteLine("--> Patates Kg: " + patatoPrice + "₺");
			Console.WriteLine("--> Domates Kg: " + tomatoPrice + "₺");
			Console.WriteLine("---------------------------------------------------------------------------------------------------------");
			double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
			appleGram = 2.415;
			orangeGram = 1.365;
			strawberryGram = 0.498;
			patatoGram = 15.748;
			tomatoGram = 3.457;

			double appleToralPrice = Math.Round(appleGram * applePrice,2);
			double orangeToralPrice = Math.Round(orangeGram * orangePrice,2);
			double strawberryToralPrice = Math.Round(strawberryGram * strawberryPrice,2);
			double patatoToralPrice = Math.Round(patatoGram * patatoPrice,2);
			double tomatoToralPrice = Math.Round(tomatoGram * tomatoPrice, 2);

			Console.WriteLine("Alınan Ürün:Elma -> " + "Kg Fiyatı:" + applePrice + "₺ /" + " Alınan Miktar:" + appleGram+"Gr /" + " Toplam Tutar:" + appleToralPrice+"₺");
			Console.WriteLine("Alınan Ürün:Portakal -> " + "Kg Fiyatı:" + orangePrice + "₺ /" + " Alınan Miktar:" + orangeGram + "Gr /" + " Toplam Tutar:" + orangeToralPrice + "₺");
			Console.WriteLine("Alınan Ürün:Çilek -> " + "Kg Fiyatı:" + strawberryPrice + "₺ /" + " Alınan Miktar:" + strawberryGram + "Gr /" + " Toplam Tutar:" + strawberryToralPrice + "₺");
			Console.WriteLine("Alınan Ürün:Patates -> " + "Kg Fiyatı:" + patatoPrice + "₺ /" + " Alınan Miktar:" + patatoGram + "Gr /" + " Toplam Tutar:" + patatoToralPrice + "₺");
			Console.WriteLine("Alınan Ürün:Domates -> " + "Kg Fiyatı:" + tomatoPrice + "₺ /" + " Alınan Miktar:" + tomatoGram + "Gr /" + " Toplam Tutar:" + tomatoToralPrice + "₺");

			double shoppingTotalPrice = appleToralPrice + orangeToralPrice + strawberryToralPrice + patatoToralPrice + tomatoToralPrice;
			Console.WriteLine("---------------------------------------------------------------------------------------------------------");
			Console.WriteLine("Toplam Kasa Tutarı:"+shoppingTotalPrice+"₺");
			#endregion

			#region Klavyeden Veri Girişleri String
			Console.WriteLine("-------------------------------------------------------");
			string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

			Console.WriteLine("***** Lynch Hava Yolları Yolcu Bilgisi *****");
			Console.WriteLine();

			Console.Write("Yolcu TC Kimlik No:");
			passengerIdentityNumber = Console.ReadLine();

			Console.Write("Yolcu Adı: ");
			passengerName = Console.ReadLine();

			Console.Write("Yolcu Soyadı:");
			passengerSurname = Console.ReadLine();

			Console.Write("Yolcu Yaş:");
			passengerAge = Console.ReadLine();

			Console.Write("İlçe Bilgisi:");
			passengerDistrict = Console.ReadLine();

			Console.Write("Şehir Bİlgisi:");
			passengerCity = Console.ReadLine();
			Console.WriteLine("-------------------------------------------------------");

			Console.WriteLine("Yolcu Tc No:" + passengerIdentityNumber + " /" + " Ad Soyad:" + passengerName + " " + passengerSurname + " / " + "Yaş:" + passengerAge + " / " + "Adres:" + passengerDistrict + "|" + passengerCity);

			#endregion

			#region Klavyeden Veri Girişi Int
			int shoesPrice, computerPrice, chairPrice, tvPrice;
			shoesPrice = 250;
			computerPrice = 26874;
			chairPrice = 698;
			tvPrice = 36999;
			Console.WriteLine("---------------------------------------------------------------------------------------------------------");
			Console.WriteLine();
			Console.WriteLine("***** Lynch'in Mağazası *****");
			Console.WriteLine();
			Console.WriteLine("Ayakkabı Fiyatı:" + shoesPrice + "₺");
			Console.WriteLine("Bilgisayar Fiyatı:" + computerPrice + "₺");
			Console.WriteLine("Sandalye Fiyatı:" + chairPrice + "₺");
			Console.WriteLine("Televizyon Fiyatı:" + tvPrice + "₺");
			Console.WriteLine("---------------------------------------------------------------------------------------------------------");

			int shoesCount, computerCount, chairCount, tvCount;

			Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
			shoesCount = int.Parse(Console.ReadLine());

			Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
			computerCount = int.Parse(Console.ReadLine());

			Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
			chairCount = int.Parse(Console.ReadLine());

			Console.Write("Lütfen aldığınız televizyon sayısını giriniz:");
			tvCount = int.Parse(Console.ReadLine());

			int totalPrice = shoesCount * shoesPrice + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
			Console.WriteLine("---------------------------------------------------------------------------------------------------------");
			Console.WriteLine("Toplam Ödemeniz Gereken Tutar:" + totalPrice + "₺");
			#endregion

			#region Klavyeden Veri Girişi Double
			Console.WriteLine("---------------------------------------------------------------------------------------------------------");
			Console.WriteLine("***** 11-B Sınav Notları Hesaplama *****");
			Console.WriteLine();
			double exam1, exam2, exam3, result;

			Console.Write("Lütfen 1. sınav notunu giriniz:");
			exam1 = double.Parse(Console.ReadLine());

			Console.Write("Lütfen 2. sınav notunu giriniz:");
			exam2 = double.Parse(Console.ReadLine());

			Console.Write("Lütfen 3. sınav notunu giriniz:");
			exam3 = double.Parse(Console.ReadLine());
			Console.WriteLine("---------------------------------------------------------------------------------------------------------");
			result = (exam1 + exam2 + exam3) / 3;
			Console.WriteLine("Ortalama sınav notu:" + result);


			#endregion

			Console.Read();
		}
	}
}
