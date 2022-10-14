using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			merhaba msj = new merhaba();
			msj.metın();
			
			kisiler kisi = new kisiler();
			kisi.kisilistesi();
			Console.ReadKey();
		}
	}
}
