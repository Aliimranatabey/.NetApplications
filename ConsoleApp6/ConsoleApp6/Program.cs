using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Multiply(2, 4));
			Console.WriteLine(Multiply(2, 4,8));
			Console.WriteLine(Add4(1,2,3,4,5,6));
			Console.ReadLine();
		}

		static int Multiply(int number1 ,int number2)
		{
			return number1 * number2;
		}

		static int Multiply(int number1,int number2, int number3)
		{
			return number1 * number2 * number3;
		}
		static int Add4 (params int[] numbers)
		{
			return numbers.Sum();
		}
	}

}
