using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegiskenlerOrnek
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ad, soyad;
			int vize, final, proje;
			double ort;
			ad = textBox1.Text;
			soyad = textBox2.Text;
			vize = Convert.ToInt32(textBox3.Text);
			final = Convert.ToInt32(textBox4.Text);
			proje = Convert.ToInt32(textBox5.Text);
			ort = (vize * 40 / 100) + (final * 60 / 100) + (proje * 20 / 100);
			listBox1.Items.Add(ad + " " + soyad + " Ortalama : " + ort);

		}
	}
}
