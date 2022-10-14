using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				throw new NullReferenceException("C");
				Console.WriteLine("istisna meydana geldi");
			}
			catch(ArithmeticException e)
			{
				Console.WriteLine("istisna yakalandı");
			}
			Console.ReadLine();
		}
	}
}
