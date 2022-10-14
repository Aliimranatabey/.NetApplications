using System;

namespace Ödev3Uygulama2
{
	class Program
	{
		static void Main(string[] args)
		{
			//UYGULAMA 2

			Console.WriteLine("Bir sayı giriniz");
			int sayı = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine();

			int toplam = 0;
			
			
			for(int i = 1; i < sayı+1; i++)
			{
				int k = 1;

				for (int j = 1; j < sayı+1; j++)
				{
					Console.Write("           ");
					Console.WriteLine(k);
					Console.WriteLine(" " + i, " " + j);
					toplam = toplam + k + i;
					k = k + 1;
					


				}
				
				Console.WriteLine();
				
			}
			Console.WriteLine(toplam);
			Console.ReadKey();
		}
	}
}
