using System;

namespace Ödev6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Cep Telefonunuzu Giriniz : ");
			long tel = long.Parse(Console.ReadLine());
			tel = Math.Abs(tel);

			long basamak = 0;
			while (tel >= 1)
			{
				tel /= 10;
				basamak++;
			}
			Console.WriteLine("Girilen telefon " + basamak + " basamaklıdır ");

			long ilkbasamak = tel / 1000000000;

			if (basamak != 10 || ilkbasamak != 5)
			{
				Console.WriteLine("(HATA 404 ERROR) Yeni bir telefon giriniz lütfen !!! ");
			}

			long sonuc = 0;
			while (tel > 0)
			{
				sonuc += (tel % 10);
				tel = tel / 10;
			}
			Console.WriteLine("Girdiğiniz Sayının Rakamları Toplamı : " + sonuc);
			Console.ReadKey();
		}
	

		}
	}

