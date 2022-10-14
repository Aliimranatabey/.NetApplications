using System;

namespace ödev2Uygulama3
{
	class Program
	{
		static void Main(string[] args)
		{
			

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




		}
	}
}
