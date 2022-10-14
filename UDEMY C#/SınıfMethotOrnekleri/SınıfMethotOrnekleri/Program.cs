using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfMethotOrnekleri
{
	class Program
	{
		static void Main(string[] args)
		{
			bilgiler özllkler = new bilgiler();

			string ad, soyad, meslek;
			int yaş;
			Console.Write("Adınızı Giriniz : ");
			ad = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Soyadınızı Giriniz : ");
			soyad = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Mesleğinizi Giriniz : ");
			meslek = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Yaşınızı Giriniz : ");
			yaş = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine();
			özllkler.ad(ad);
			özllkler.soyad(soyad);
			özllkler.meslek(meslek);
			özllkler.yas(yaş);
			Console.ReadKey();
		}
	}
}
