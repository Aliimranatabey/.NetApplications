using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Integer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int kisa,uzun,alan,cevre;
			kisa = 5;
			uzun = 6;
			alan = kisa * uzun;
			cevre = 2 * (kisa + uzun);
			label1.Text="Dikdortgenin Alani :"+alan +" Dikdortgenin Cevresi :" + cevre;



		}

		private void button2_Click(object sender, EventArgs e)
		{
			int sinav1, sinav2, sinav3, ort;
			sinav1 = 40;
			sinav2 = 50;
			sinav3 = 60;
			ort = (sinav1 + sinav2 + sinav3) / 3;
			label2.Text = "Ögrencinin Sinav Notlarinin Ortalamasi :" + ort;

		}
	}
}
