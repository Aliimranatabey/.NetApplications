using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
	class Program
	{
		static void Main(string[] args)
		{
			/*int i = 1;
			do
			{
				Console.Write(i );
				i++;
				if (i < 101)
				{
					Console.Write(",");
				} 

			} while (i < 101);
			Console.ReadKey();*/

			for(int j = 1; j < 101; j++)
			{
				Console.Write(j);
				if (j < 100)
				{
					Console.Write(",");

				}
				
			}
			Console.ReadKey();

		}
	}
}
