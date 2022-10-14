using System;

namespace Vize
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] dizi = new int[] { 1, 2, 3, 4, 5 };
			fonk(ref dizi);
			Console.ReadLine();

		}
		static void fonk(ref int[] x)
		{
			for (int i = 0; i < x.Length; i++)
			{
				x[i] = x[i] + 5;
				Console.Write(x[i] + "");

				Convert.ToInt32

			}
		}
		static void asda(ref int[] x)
		{
			for (int i = 0; i < x.Length; i++)
			{
				x[i] = x[i] + 5;
				Console.Write(x[i] + "");

			}
		}
		static void fonk(ref int[] x)
		{
			for (int i = 0; i < x.Length; i++)
			{
				x[i] = x[i] + 5;
				Console.Write(x[i] + "");

			}
		}


	}

}
