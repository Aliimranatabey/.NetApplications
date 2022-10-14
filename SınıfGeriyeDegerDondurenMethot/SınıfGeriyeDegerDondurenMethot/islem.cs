using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfGeriyeDegerDondurenMethot
{
	class islem
	{
		public int topla(int s1, int s2)
		{
			int toplam = s1 + s2;
			Console.WriteLine("TOPLAM : " + toplam);
			return toplam;
		}
		public int carp(int s1, int s2)
	    {
		   int carpım = s1 * s2;
			Console.WriteLine("ÇARPIM :" + carpım);
		   return carpım;
		}
		public int fark(int s1, int s2)
		{
			int farkı = s1 - s2;
			Console.WriteLine("FARK :" + farkı);
			return farkı;
		}
		public int bol(int s1,int s2)
		{
			int bolum = s1 / s2;
			Console.WriteLine("BOLUM :"+bolum);
			return bolum;
		}
		
	}
}
