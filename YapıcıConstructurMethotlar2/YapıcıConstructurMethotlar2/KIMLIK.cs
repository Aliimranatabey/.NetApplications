using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıConstructurMethotlar2
{
	class KIMLIK
	{
		string ad;
		string soyad;
		int yas;
		string memleket;
		char cinsiyet;

		public string AD
		{
			get { return ad; }
			set { ad = value.ToUpper(); }
		}
		public string SOYAD
		{
			get { return soyad; }
			set { soyad = value.ToUpper(); }
		}
		public int YAS
		{
			get { return yas; }
			set { yas = Math.Abs(value); }	
		}
		public string MEMLEKET
		{
			get { return memleket; }
			set { memleket = value.ToUpper(); }
		}
		public char CINSIYET
		{
			get { return cinsiyet; }
			set { cinsiyet = value; }
		}
		public KIMLIK()
		{
			ad = "bilinmiyor";
			soyad = "bilinmiyor";
			yas = 18;
			memleket = "malatya";
			cinsiyet = 'E';
		}

			
		
	}
}
