using System;

namespace Ödev4Uygulama3
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Sayı Dizisinin kaç elamanlı oldugunu giriniz ");
			int sayılar = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			int[] butunsayılar = new int[sayılar];
			for (int i = 0; i < sayılar; i++)
			{
				Console.Write(i + ". Sayıyı giriniz : ");
				butunsayılar[i] = Convert.ToInt32(Console.ReadLine());

			}

			for (int j = 0; j <sayılar;j++)
			{
				if (butunsayılar[j] < 0)
				{
					Console.WriteLine("Negatif Sayılar :"+butunsayılar[j] );
					
				}
				else
				{
					Console.WriteLine("Pozitif Sayılar :" + butunsayılar[j]);
					
				}
				
			}
			


			Console.ReadKey();
			
		}
	}
}
