using System;

namespace ConsoleApp18
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] students = new string[3];
			students[0] = "Engin";
			students[1] = "Derin";
			students[2] = "Salih";

			string[] students2 = new[] { "Engin", "Derin", "Salih" };
			foreach (var student in students)
			{

				Console.WriteLine(student);

			}
			foreach (var student in students2)
			{

				Console.WriteLine(student);

			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
