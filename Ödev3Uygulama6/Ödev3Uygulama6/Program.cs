using System;

namespace Ödev3Uygulama6
{
	class Program
	{
		static void Main(string[] args)
		{
			int satir;
			Console.Write("Baklava diliminin boyutunu giriniz = ");
			satir = int.Parse(Console.ReadLine());

			
			for (int i = 0; i <= satir; i++)
			{

				for (int j = 0; j <= (satir + 1) - i; j++)

					Console.Write("  ");

				for (int k = 0; k <= 2 * i - 2; k++)

					Console.Write("**");

				Console.WriteLine();

			}

			
			for (int m = 0; m <= satir; m++)
			{

				for (int n = 0; n <= m; n++)

					Console.Write("  ");

				for (int z = m * 2; z <= satir * 2; z++)

					Console.Write("**");

				Console.WriteLine();

			}
			
			Console.ReadKey();
		}
	}
}
