using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfGeriyeDegerDondurenMethot
{
	class Program
	{
		static void Main(string[] args)
		{
			islem isl = new islem();
			isl.topla(5, 7);
			isl.fark(4, 8);
			isl.carp(3, 9);
			isl.bol(18, 6);
			Console.ReadKey();

		}
	}
}
