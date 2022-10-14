using System;

namespace ConsoleApp14
{
	class Program
	{
		static void Main(string[] args)
		{
			int alis, kdv, kar, toplam;
			Console.Write("Alış Fiyatını Giriniz :");
			alis = Convert.ToInt16(Console.ReadLine());
			Console.Write("Vergi tutarını giriniz (%): ");
			kdv = Convert.ToInt16(Console.ReadLine());
			Console.Write("Kar oranını giriniz (%): ");
			kar = Convert.ToInt16(Console.ReadLine());
			toplam = alis + ((alis * kdv) / 100) + ((alis * kar) / 100);
			Console.Write("Toplam Tutar :" + toplam);
			Console.ReadKey();

		}
	}
}
