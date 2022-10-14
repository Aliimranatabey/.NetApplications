using System;

namespace Ödev3Uygulama1
{
	class Program
	{
		static void Main(string[] args)
		{
			//UYGULAMA 1

			for (int i = 1; i < 11; i++)
			{
				for (int j = 1; j < 11; j++)
				{
					Console.Write("{0}*{1}={2}\t", i, j, (i * j));
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
