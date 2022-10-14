using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yaztasmim
{
	class Program
	{
		class Gadget
		{
			public String islem1() { return "GADGET HAZIRLANIYOR \n"; }
			public String islem2() { return "GADGET UCMAYA HAZIRLANIYOR \n"; }

		}
		class Spencer
		{
			public String islem1() { return "SPENCER HAZIRLANIYOR"; }
			public String islem2() { return "ATES ETMEYE HAZIRLANIYOR"; }
		}
		class Cephe
		{
			protected Gadget _g;
			protected Spencer _s;

			public Cephe(Gadget altg, Spencer alts)
			{
				this._g = altg;
				this._s = alts;
			}
			public String Islem()
			{
				String sonuc = "Cephe Alt Sistemleri Baslattır";
				sonuc += this._g.islem1();
				sonuc += this._s.islem1();
				sonuc += "cephe tasarım alt sistemlere islem göderiyor";
				sonuc += this._g.islem2();
				sonuc += this._s.islem2();
				return sonuc;
			}
			static void Main(string[] args)
			{
				Gadget altg = new Gadget();
				Spencer alts = new Spencer();
				Cephe tep = new Cephe(altg, alts);
				Console.WriteLine(tep.Islem());
				Console.ReadKey();
			}


		}
	}
	
}
