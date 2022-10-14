using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıConstructurMethotlar2
{
	class Program
	{
		static void Main(string[] args)
		{
			
			KIMLIK kml = new KIMLIK();
			kml.AD = "ALİ İMRAN";
			kml.SOYAD = "ATABEY";
			kml.YAS = 19;
			
			Console.WriteLine("ADI :" +kml.AD);
			Console.WriteLine("SOYADI :" +kml.SOYAD);
			Console.WriteLine("YAŞI :" +kml.YAS);
			Console.WriteLine("MEMLEKETİ :" +kml.MEMLEKET);
			Console.WriteLine("CİNSİYETİ :" +kml.CINSIYET);
			Console.Read();
		}
	}
}
