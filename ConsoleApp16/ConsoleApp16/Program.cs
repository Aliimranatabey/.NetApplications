using System;

namespace ConsoleApp16
{
	class Program
	{
		static void Main(string[] args)
		{
			int buyuk = 0, kucuk = 0, sayi;
			for (int i = 1; i <= 25; i++)
			{
				Console.Write("{0}. sayıyı giriniz: ", i);
				sayi = Convert.ToInt32(Console.ReadLine());
				if (i == 1)
				{
					buyuk = sayi;
					kucuk = sayi;
				}
				if (kucuk > sayi)
				{ kucuk = sayi; }
				if (buyuk < sayi)
				{ buyuk = sayi; }

				if (kucuk % 2 == 0)
				{
					kucuk = sayi;
				}
				if (buyuk % 2 == 1)
				{
					buyuk = sayi;
				}
			}

			int toplam = buyuk + kucuk;
			Console.WriteLine("En büyük sayı {0}", buyuk);
			Console.WriteLine("En küçük sayı {0}", kucuk);
			Console.WriteLine("İkisinin Toplamı :"+ toplam);
			Console.ReadKey();
		}
	}
}
	

