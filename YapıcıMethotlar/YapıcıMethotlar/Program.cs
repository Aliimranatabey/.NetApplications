using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMethotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			string ad, soyad, meslek;
			int yas;
			Console.Write("ADINIZI GİRİNİZ : ");
			ad=Console.ReadLine();
			Console.WriteLine();
			Console.Write("SOYADINIZI GİRİNİZ : ");
			soyad = Console.ReadLine();
			Console.WriteLine();
			Console.Write("YAŞINIZI GİRİNİZ : ");
			yas = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine();
			Console.Write("MESLEĞİNİZİ GİRİNİZ : ");
			meslek = Console.ReadLine();
			Console.WriteLine();
			ogrenci ogr = new ogrenci(ad,soyad,yas,meslek);
			Console.Read();
		}
	}
}
