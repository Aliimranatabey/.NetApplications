using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_ÖdevSoru
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int toplam;
			int sayi1 = Convert.ToInt16(textBox1.Text);
			int sayi2 = Convert.ToInt16(textBox2.Text);
			string sembol = textBox3.Text;

			switch (sembol)
			{
				case "+": toplam = sayi1 + sayi2; textBox4.Text = toplam+" "; break;
				case "-": toplam = sayi1 - sayi2; textBox4.Text = toplam+" "; break;
				case "*": toplam = sayi1 * sayi2; textBox4.Text = toplam+" "; break;
				case "/": toplam = sayi1 / sayi2; textBox4.Text = toplam.ToString; break;
				default:textBox4.Text="Hatalı Sembol Girişi !";break;

			}
		}
	}
}
