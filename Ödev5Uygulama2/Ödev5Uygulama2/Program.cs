using System;

namespace Ödev5Uygulama2
{
	class Program
	{
		static double AlanHesapla(double a, double h)
		{
			double alan;
			alan = (a * h) / 2;
			return alan;
		}
		static void Main(string[] args)
		{
			double taban, yükseklik, alan;
			Console.Write("Lütfen Üçgenin Tabanını Giriniz = ");
			taban = double.Parse(Console.ReadLine());
			Console.Write("Lütfen Üçgenin Yüksekliğini Giriniz = ");
			yükseklik = double.Parse(Console.ReadLine());
			alan = AlanHesapla(taban, yükseklik);
			Console.Write("Üçgenin Alanı = {0}", alan);
			Console.ReadKey();
		}
	}
}
