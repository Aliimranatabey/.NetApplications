using System;

namespace Ödev3Uygulama4
{
	class Program
	{
		static void Main(string[] args)
		{
			string name, name2;
			Console.Write("Lütfen Bir Ay İsmi Giriniz = ");
			name = Convert.ToString(Console.ReadLine());
			name2 = name.ToLower();
			switch (name2)
			{
				case "ocak":
					Console.Write("Ocak 1. Aydır");
					break;
				case "şubat":
					Console.Write("Şubat 2. Aydır");
					break;
				case "mart":
					Console.Write("Mart 3. Aydır");
					break;
				case "Nisan":
					Console.Write("Nisan 4. Aydır");
					break;
				case "mayıs":
					Console.Write("Mayıs 5. Aydır");
					break;

				case "haziran":
					Console.Write("Haziran 6. Aydır");
					break;

				case "temmuz":
					Console.Write("Temmuz 7. Aydır");
					break;

				case "ağustos":
					Console.Write("Ağustos 8. Aydır");
					break;

				case "eylül":
					Console.Write("Eylül 9. Aydır");
					break;
				case "ekim":
					Console.Write("Ekim 10. Aydır");
					break;
				case "kasım":
					Console.Write("Kasım 11. Aydır");
					break;
				case "aralık":
					Console.Write("Aralık 12. Aydır");
					break;
				default:
					Console.Write("Böyle Dir Ay Yoktur!");
					break;
			}

			Console.ReadKey();
		}
	}
	}

