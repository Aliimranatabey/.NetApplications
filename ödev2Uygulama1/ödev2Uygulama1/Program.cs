using System;

namespace ödev2Uygulama1
{
	class Program
	{
		static void Main(string[] args)
		{
			//UYGULAMA 1

			Console.WriteLine("Bir sayı giriniz : ");
			int sayi1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Bir sayı giriniz : ");
			int sayi2 = Convert.ToInt32(Console.ReadLine());

			int toplam = sayi1 + sayi2;
			int fark = sayi1 - sayi2;
			int carpim = sayi1 * sayi2;
			int bolüm = sayi1 / sayi2;

			Console.WriteLine(toplam);
			Console.WriteLine(fark);
			Console.WriteLine(carpim);
			Console.WriteLine(bolüm);
			Console.ReadKey();

			

		}
	}
}
