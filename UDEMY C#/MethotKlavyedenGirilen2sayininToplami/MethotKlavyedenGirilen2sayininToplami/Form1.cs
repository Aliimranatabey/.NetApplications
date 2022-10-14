using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethotKlavyedenGirilen2sayininToplami
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int toplam(int s1,int s2)
		{
			int top = s1 + s2;
			return top;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			int sayi1 = Convert.ToInt32(textBox1.Text);
			int sayi2 = Convert.ToInt32(textBox2.Text);

			label2.Text = toplam(sayi1,sayi2).ToString();

		}
	}
}
