using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
	class Program
	{
		static void Main(string[] args)
		{
			int teksayiadeti = 0;
			int ciftsayiadeti = 0;
			int teksayilartoplamı = 0;
			int ciftsayilartoplamı = 0;
			Console.WriteLine("Sayı adeti giriniz");
			int sayiadedi = Convert.ToInt32(Console.ReadLine());

			int[] sayilar = new int[sayiadedi];
			for (int i = 1; i <= sayiadedi; i++)
			{
				Console.WriteLine("Sayi Giriniz");
				int sayi = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(sayilar[i]);

				if (sayilar[i] % 2 == 0)
				{
					ciftsayiadeti = ciftsayiadeti + 1;
					ciftsayilartoplamı = ciftsayilartoplamı + sayilar[i];
				}

				else if (sayilar[i] % 2 != 0)
				{
					teksayiadeti = teksayiadeti + 1;
					teksayilartoplamı = teksayilartoplamı + sayilar[i];
				}
			
			}

			Console.WriteLine("ÇİFT SAYILAR ADEDİ :" + ciftsayiadeti);
			Console.WriteLine("ÇİFT SAYILAR TOPLAMI :" + ciftsayilartoplamı);
			Console.WriteLine("TEK SAYILAR ADEDİ :" + teksayiadeti);
			Console.WriteLine("TEK SAYILAR TOPLAMI :" + teksayilartoplamı);

		}
	}
}
