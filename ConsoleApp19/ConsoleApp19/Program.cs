using System;

namespace ConsoleApp19
{
	class Program
	{
		static void Main(string[] args)
		{
			string[,] regions = new string[5, 3]
			{
				{"İstanbul","Edirne","Bursa" },
				{"Ankara","Konya","Kırıkkale" },
				{"Malatya","Elazığ","Ağrı" },
				{"Antalya","Adana","Mersin" },
				{"Rize","Trabzon","Samsun" }
				
			};

			for(int i = 0; i <= regions.GetUpperBound(0); i++)
			{
				for(int j = 0; j <= regions.GetUpperBound(1); j++)
				{
					Console.Write(regions[i, j]);
					Console.Write("\n");
				}
				Console.WriteLine();
				Console.WriteLine("**************************");
			}
			Console.ReadLine();
		}
	}
}
