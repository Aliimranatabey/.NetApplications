using System;

namespace Ödev3Uygulama4
{
	class Program
	{
		static void Main(string[] args)
		{
			string kelime;
			int i;
			
			Console.Write("Bir Kelime Giriniz = ");
			kelime = Console.ReadLine();
			
			int uzunluk = kelime.Length;
			
			char[] dizi = new char[uzunluk];
			
			for (i = 0; i < uzunluk; i++)
			{
				dizi[i] = kelime[i];
			}
			
			Array.Sort(dizi);
			
			Console.WriteLine("---------------------------------");
			Console.Write("Alfabetik sıralı hali :");
			for (i = 0; i < uzunluk; i++)
			{
				Console.Write(dizi[i]);
			}
			Console.ReadLine();
		}
	}
}
