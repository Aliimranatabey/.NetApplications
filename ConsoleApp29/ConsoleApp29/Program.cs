using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
	class Program
	{
		static void Main(string[] args)
		{
			int teksayiadeti = 0;
			int ciftsayiadeti = 0;
			Console.WriteLine("Sayı adeti giriniz");
			int sayı = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < sayı; i++)
			{
				if (i % 2 == 0)
				{
					ciftsayiadeti = ciftsayiadeti + 1;
				}

				else if (i % 2 != 0)
				{
					teksayiadeti = teksayiadeti + 1;
				}

			}
			Console.WriteLine("TEK SAYI ADEDİ :"+teksayiadeti);
			Console.WriteLine("ÇİFT SAYI ADEDİ :" + ciftsayiadeti);

			Console.ReadLine();
		}
	}
}
