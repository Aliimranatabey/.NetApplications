using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Ornek1
{
	class Class1: Class2
	{
		public string marka;
		public int model;
		public string renk;
		public string durum;
		public string yakıt;

		private string hasar;
		private double motor;

		public string hasarı
		{
			get { return hasar; }
			set { hasar = value.ToUpper(); }

		}

		public double motoru
		{
			get { return motor; }
			set { motor = Math.Abs(value); }
		}
	}
}
