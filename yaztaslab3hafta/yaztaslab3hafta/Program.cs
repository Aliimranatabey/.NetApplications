using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yaztaslab3hafta
{
	class Program
	{
		interface IBilesen
		{
			string Oprerasyon();
		}
		class Bilesen : IBilesen
		{
			public string Opreasyon()
			{
				return "1,2,3,4";
			}
		}
		class DekoratorA : IBilesen
		{
			private IBilesen bilesen;
			public DekoratorA(IBilesen b)
			{
				bilesen = b;
			}
			public string Operasyon()
			{
				string s = bilesen.Oprerasyon();
				s += "5,6,7,8";
				return s;
			}
			class DekoratorB : IBilesen
			{
				private IBilesen bilesen;

				public DekoratorB(IBilesen B)
				{
					bilesen = B;
				}
				public string operasyon()
				{
					string s = bilesen.operasyon();
					s += "9 10 11 12";
					return s;
				}
				public string yenidavranis()
				{
					return "13 14 15 16";
				}
			}
		}
		
		static void Main(string[] args)
		{
			Bilesen bilesen = new Bilesen();
			Console.WriteLine();
		}
	}
}
