using System;

namespace ödev2Uygulama7
{
	class Program
	{
		static void Main(string[] args)
		{

			

			//UYGULAMA 7

			int d, r, g;
			double pi = 3.14;

			Console.WriteLine("Açıyı giriniz = ");
			d = Convert.ToInt32(Console.ReadLine());

			r = Convert.ToInt32(d * pi / 180);
			g = d * 200 / 180;

			Console.WriteLine("Radyan = " + r);
			Console.WriteLine("Grad = " + g);
			Console.ReadKey();



		}
	}
}
