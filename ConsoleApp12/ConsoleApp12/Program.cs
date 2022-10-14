using System;

namespace ConsoleApp12
{
	class Program
	{

		//UYGULAMA 1
		static void Main(string[] args)
		{
			
			 for(int i=1 ; i<11; i++)
			{
				for(int j=1; j<11; j++)
				{
					Console.Write("{0}*{1}={2}\t", i, j, (i * j));
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
