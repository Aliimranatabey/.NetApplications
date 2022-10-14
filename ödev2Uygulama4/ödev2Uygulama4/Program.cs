using System;

namespace ödev2Uygulama4
{
	class Program
	{
		static void Main(string[] args)
		{
			



			//UYGULAMA 4

			Console.WriteLine("Bir sayı giriniz : ");
			int k = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Bir sayı giriniz : ");
			int s = Convert.ToInt32(Console.ReadLine());

			int kalan = k % s;
			double bolum = k / s;
			if (kalan == 0)
			{
				Console.WriteLine("Girilen iki sayı birbirine tam bölünür ve bölüm : " + (int)bolum);
			}
			else
			{
				Console.WriteLine("Girilen iki sayı birbirine tam bölünümez ve bölüm : " + bolum);
			}
			Console.ReadKey();

			

		}
	}
}
