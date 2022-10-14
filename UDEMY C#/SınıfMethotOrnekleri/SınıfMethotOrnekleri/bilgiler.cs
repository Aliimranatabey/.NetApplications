using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfMethotOrnekleri
{
	class bilgiler
	{
		public void ad(string isim){
			for (int i = 1; i < 4; i++)
			{
				Console.WriteLine(isim);
			}
		}
		public void soyad(string soyisim) {

			for (int i = 1; i < 4; i++)
			{
				Console.WriteLine(soyisim);
			}
		}
		public void meslek(string mesleği) {

			for (int i = 1; i < 4; i++)
			{
				Console.WriteLine(mesleği);
			}
		}
		public void yas(int yasi) {
			for (int i = 1; i < 4; i++)
			{
				Console.WriteLine(yasi.ToString());
			}

		}

	}
}
