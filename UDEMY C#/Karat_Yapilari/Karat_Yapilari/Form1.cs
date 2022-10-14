using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karat_Yapilari
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//1 kitap 8 tl
			int kitapadedi;
			double sonuc;
			kitapadedi = Convert.ToInt16(textBox1.Text);

			if(kitapadedi>=0 && kitapadedi <= 20)
			{
				sonuc = (kitapadedi * 8) - ((kitapadedi * 8) * 20 / 100);
				textBox2.Text = sonuc.ToString() + " TL";
			}
			if(kitapadedi>=21 && kitapadedi <= 40)
			{
				sonuc = (kitapadedi * 8) - ((kitapadedi * 8) * 40 / 100);
				textBox2.Text = sonuc.ToString() + " TL";

			}
			if (kitapadedi >= 41)
			{
				sonuc = (kitapadedi * 8) - ((kitapadedi * 8) * 50 / 100);
				textBox2.Text = sonuc.ToString() + " TL";
			}
			
		}
	}
}
