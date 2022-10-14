using System;

namespace ConsoleApp15
{
	class Program
	{
		static void Main(string[] args)
		{
			int buyuk = 0;
			int kucuk = 0;
			for (int i= 1;i<=25;i++) {
				Console.WriteLine("Bir Sayı Giriniz :");
				int sayi = Convert.ToInt32(Console.ReadLine());
				if (i <= 25)
				{
					buyuk = sayi;
					kucuk = sayi;
				}
				if (kucuk > sayi)
				{
					if (kucuk % 2 == 0) {
						kucuk = sayi;
					}
				 }
				if (buyuk < sayi) { 
					if (buyuk % 2 == 1)
					{
						buyuk = sayi;
					}
				 }

			
		}
			int toplam = buyuk + kucuk;
			Console.WriteLine("En buyuk tek sayı ile en küçük çift sayının toplamı =" + toplam);
			Console.ReadLine();
		}
	}
}
