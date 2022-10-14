using System;

namespace Ödev4Uygulama1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dizinin Kaç Elemanlı Olduğunu Giriniz");
			int boyut = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			int[] sayı = new int[boyut];
			for (int i = 0; i < boyut; i++)
			{
				Console.Write(i+". Sayıyı giriniz : ");
				sayı[i] = Convert.ToInt32(Console.ReadLine());
				
			}
			Array.Reverse(sayı);
			Console.WriteLine("*************************");
			
			foreach(int i in sayı)
			{

				System.Console.WriteLine("Dizinin "+i+".Sayısı  :"+i, i);

			}
			Console.WriteLine("Dizinin Kaçınıc elemanını görmek istiyorsunuz ?");
			int eleman = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("*************************");
			Array.Reverse(sayı);

			Console.Write("İstediğiniz " + eleman + ". Elaman =" +sayı[eleman]);

			Console.ReadKey();

		}
	}
}
