using System;

namespace ödev2
{
	class Program
	{
		static void Main(string[] args)
		{
			//UYGULAMA 1

			Console.WriteLine("Bir sayı giriniz : ");
			int sayi1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Bir sayı giriniz : ");
			int sayi2 = Convert.ToInt32(Console.ReadLine());

			int toplam = sayi1 + sayi2;
			int fark = sayi1 - sayi2;
			int carpim = sayi1 * sayi2;
			int bolüm = sayi1 / sayi2;

			Console.WriteLine(toplam);
			Console.WriteLine(fark);
			Console.WriteLine(carpim);
			Console.WriteLine(bolüm);
			Console.ReadKey();

			//UYGULAMA 2

			double örnek1 = 36 / 6 / 3;
			double örnek2 = 8 / 4 * 2;
			double örnek3 = 4 ^ 2 + 6 - 1 + 3;
			double örnek4 = (3 + 2) * 4 - 1 + 6 / 2;
			double örnek5 = (5 - 2) * 2 - 1 + 8^2 / 2;

			Console.WriteLine(örnek1);
			Console.WriteLine(örnek2);
			Console.WriteLine(örnek3);
			Console.WriteLine(örnek4);
			Console.WriteLine(örnek5);
            Console.ReadKey(); 

			//UYGULAMA 3 

			int x = 24;
			int y = 11;
			int z = 34;

			Boolean a = 23 == 55 && 76 > 45 && 5 < 12;
			Console.WriteLine(a ? "doğru" : "yanlıs");
			

			Boolean b = 23 >= 23 && 45 != 18;
			Console.WriteLine(b ? "doğru" : "yanlıs");

			Boolean c = x > y && z == y && z < x;
			Console.WriteLine(c ? "doğru" : "yanlıs");

			Boolean d = z > x && y < x;
			Console.WriteLine(d ? "doğru" : "yanlıs");

			Console.ReadKey();

			

			//UYGULAMA 4

			Console.WriteLine("Bir sayı giriniz : ");
			int k = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Bir sayı giriniz : ");
			int s = Convert.ToInt32(Console.ReadLine());

			int kalan = k % s;
			double bolum = k / s;
			if (kalan == 0)
			{
				Console.WriteLine("Girilen iki sayı birbirine tam bölünür ve bölüm : " + (int)bolum);
			}
			else
			{
				Console.WriteLine("Girilen iki sayı birbirine tam bölünümez ve bölüm : " + bolum);
			}
			Console.ReadKey();

			//UYGULAMA 5
			 // HOCAM BUNU PEK ANLAMADIM VE YAPAMADIM ÖZÜR DİLERİM 
			/*DateTime tarih;

			tarih = DateTime.Now.Date;
			Console.WriteLine(tarih.ToString());

			Console.WriteLine(tarih.ToString().TrimEnd('0', ':'));

			int gün = DateTime.Now.Day;
			int ay = DateTime.Now.Month;
			int yıl = DateTime.Now.Year;

			for(int i = 1; 1 < 13; i++)
			{
				if (i == ay)
				{
					Console.WriteLine("Ocak");
				}
				else if (i == ay)
				{
					Console.WriteLine("Şubat");
				}
				else if (i == ay)
				{
					Console.WriteLine("Mart");
				}
				else if (i == ay)
				{
					Console.WriteLine("Nisan");
				}
				else if (i == ay)
				{
					Console.WriteLine("Mayıs");
				}
				else if (i == ay)
				{
					Console.WriteLine("Haziran");
				}
				else if (i == ay)
				{
					Console.WriteLine("Temmuz");
				}
				else if (i == ay)
				{
					Console.WriteLine("Temmuz");
				}
				else if (i == ay)
				{
					Console.WriteLine("Ağustos");
				}
				else if (i == ay)
				{
					Console.WriteLine("Eylül");
				}
				else if (i == ay)
				{
					Console.WriteLine("Ekim");
				}
				else if (i == ay)
				{
					Console.WriteLine("Kasım");
				}
				else
				{
					Console.WriteLine("Aralık");
				}
			}

			Console.ReadKey();*/
			//Diğer uygulamalarla karıştığı için konuşma satırı blokları içine aldım
			//UYGULAMA 6

			/*String a;
			double d, b, a, c, x1, x2;
			Console.Write("b sayisini giriniz.");
			s = Console.ReadLine();
			b = double.Parse(s);
			Console.Write("a sayisini giriniz.");
			s = Console.ReadLine();
			a = double.Parse(s);
			Console.Write("c sayisini giriniz.");
			s = Console.ReadLine();
			c = double.Parse(s);
			d = b * b - 4 * a * c;

			if (d < 0)
			{
				Console.WriteLine("Gercek kok yoktur.");
				Console.Read();
			}
			if (d == 0)
			{
				Console.WriteLine("Cakisik 2 kok vardir.\n");
				Console.WriteLine("x1=x2=" + -b / 2 * a);
				Console.Read();
			}
			if (d > 0)
			{
				x1 = (-b + Math.Sqrt(d)) / (2 * a);
				x2 = (-b - Math.Sqrt(d)) / (2 * a);
				Console.WriteLine("X1=" + x1 + " " + "X2=" + x2);
				Console.Read();
				}
				*/
		

			//UYGULAMA 7

			/*int d, r, g;
			double pi = 3.14;

			Console.WriteLine("Açıyı giriniz = ");
			d = Convert.ToInt32(Console.ReadLine());

			r = Convert.ToInt32(d * pi / 180);
			g = d * 200 / 180;

			Console.WriteLine("Radyan = " + r);
			Console.WriteLine("Grad = " + g);
			Console.ReadKey();*/


















		
	}
		}
	}
