using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Class1 arb = new Class1();
			arb.marka = "AUDI Q7";
			arb.model = 2019;
			arb.renk = "BEYAZ";
			arb.durum = "2.EL";
			arb.yakıt = "BENZIN";
			arb.motoru = 2.0;
			arb.hasarı = "VAR";
			arb.muayene = 2024;
			arb.sahip = "SEFA BUYUK";
			arb.plaka = "23 BYK 1905";

			lblmarka.Text = arb.marka;
			lblmodel.Text = arb.model.ToString();
			lblrenk.Text = arb.renk;
			lbldurum.Text = arb.durum;
			lblyakıt.Text = arb.yakıt;
			lblhasar.Text = arb.hasarı;
			lblmotor.Text = arb.motoru.ToString();
			lblmuayene.Text = arb.muayene.ToString();
			lblplaka.Text = arb.plaka;
			lblsahip.Text = arb.sahip;
		}
	}
}
