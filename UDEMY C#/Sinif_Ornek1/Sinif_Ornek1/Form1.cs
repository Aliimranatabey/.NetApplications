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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Class1 arb = new Class1();
			arb.marka = "AUDI Q8";
			arb.model = 2020;
			arb.renk = "SIYAH";
			arb.durum = "SIFIR";
			arb.yakıt = "BENZIN";
			arb.motoru = 2.4;
			arb.hasarı = "YOK";
			arb.muayene = 2025;
			arb.sahip = "ALI IMRAN ATABEY";
			arb.plaka = "44 ALI 1903";

			lblmarka2.Text = arb.marka;
			lblmodel2.Text = arb.model.ToString();
			lblrenk2.Text = arb.renk;
			lbldurum2.Text = arb.durum;
			lblyakıt2.Text = arb.yakıt;
			lblhasar2.Text = arb.hasarı;
			lblmotor2.Text = arb.motoru.ToString();
			lblmuayene2.Text = arb.muayene.ToString();
			lblplaka2.Text = arb.plaka;
			lblsahip2.Text = arb.sahip;



		}
	}
}
