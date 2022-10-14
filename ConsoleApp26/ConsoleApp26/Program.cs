using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
	class Program
	{

		static void Main(string[] args)
		{
			int i;
			int[] dizi = { 8, 3, 5, 1, 2 };
			int x = dizi[0];

			for (i=0;i<5;i++)
			{
				if(dizi[i] > x)
				{
					x = dizi[i];
				}
			}
			Console.Write(x);
			Console.Read();


		}

	}
}
	

