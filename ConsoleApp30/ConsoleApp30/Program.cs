using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kare, dikdörtgen ve yamuktan hangisinin alanını hesaplamak istiyorsunuz ?");
			string sekil = Convert.ToString(Console.ReadLine());

			if (sekil == "kare")
			{
				Console.WriteLine("Karenin bir kenar uzunluğunu giriniz :");
			    int kenar = Convert.ToInt16(Console.ReadLine());

				int kareninalanı = kenar * kenar;
				Console.WriteLine("KARENİN ALANI =" + kareninalanı);

			}
			else if (sekil == "dikdörtgen")
			{
				Console.WriteLine("Dikdörtgenin kısa kenar uzunluğunu giriniz :");
				int kisakenar = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Dikdörtgenin uzun kenar uzunluğunu giriniz :");
				int uzunkenar = Convert.ToInt16(Console.ReadLine());

				int dikdortgeninalanı = kisakenar * uzunkenar;
				Console.WriteLine("KARENİN ALANI =" + dikdortgeninalanı);
			}
			else if (sekil == "yamuk")
			{
				Console.WriteLine("Yamuğun alt kenar uzunluğunu giriniz :");
				int altkenar = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Yamuğun üst uzunluğunu giriniz :");
				int ustkenar = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Yamuğun yüksekliğini giriniz :");
				int yukseklik = Convert.ToInt16(Console.ReadLine());

				int yamuğunalanı = ((altkenar + ustkenar)/2)*yukseklik;
				Console.WriteLine("KARENİN ALANI =" + yamuğunalanı);
			}
			else {
				Console.WriteLine("HATALI ŞEKİL GİRDİNİZ !");
			}
			Console.ReadLine();
		}
	}
}
