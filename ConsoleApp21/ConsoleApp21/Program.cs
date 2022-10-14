using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 2, b = 1, c = 3, d = 4;
			int e, f, g, h, m;
			e = a * b + c / 2;
			f = a * (b + c) / 2;
			g = a * (b + c / 2);
			h = e - f + (d % 2);
			m = ++e * f-- + --g * h++;
			Console.WriteLine("e={0} f={1} g={2} h={3} m={4}", e, f, g, h, m);
			Console.ReadKey();
		}
	}
}
