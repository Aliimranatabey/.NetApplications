using System;

namespace ödev2Uygulama6
{
	class Program
	{
		static void Main(string[] args)
		{
			
			//UYGULAMA 6

			String s;
			double d, b, a, c, x1, x2;
			Console.Write("b sayisini giriniz.");
			s = Console.ReadLine();
			b = double.Parse(s);
			Console.Write("a sayisini giriniz.");
			s = Console.ReadLine();
			a = double.Parse(s);
			Console.Write("c sayisini giriniz.");
			s = Console.ReadLine();
			c = double.Parse(s);
			d = b * b - 4 * a * c;

			if (d < 0)
			{
				Console.WriteLine("Gercek kok yoktur.");
				Console.Read();
			}
			if (d == 0)
			{
				Console.WriteLine("Cakisik 2 kok vardir.\n");
				Console.WriteLine("x1=x2=" + -b / 2 * a);
				Console.Read();
			}
			if (d > 0)
			{
				x1 = (-b + Math.Sqrt(d)) / (2 * a);
				x2 = (-b - Math.Sqrt(d)) / (2 * a);
				Console.WriteLine("X1=" + x1 + " " + "X2=" + x2);
				Console.Read();
				}
				


			

		}
	}
}
