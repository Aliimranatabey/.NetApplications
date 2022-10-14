using System;

namespace Ödev5Uygulama1
{
	class Program
	{
		static double hacimHesapla(double a)
		{
			double hacim;
			hacim = a * a * a;
			return hacim;
		}
		static void Main(string[] args)
		{
			double kenar, hacim;
			Console.Write("Kenarı Giriniz = ");
			kenar = double.Parse(Console.ReadLine());
			hacim = hacimHesapla(kenar);
			Console.Write("Sonuç = {0}", hacim);
			Console.ReadKey();
		}
	}
}
	

