using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikFonksiyonları
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double sayi = Convert.ToDouble(textBox1.Text);
			label2.Text = Math.Abs(sayi).ToString();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double sayi = Convert.ToDouble(textBox1.Text);
			label2.Text = Math.Ceiling(sayi).ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			double sayi = Convert.ToDouble(textBox1.Text);
			label2.Text = Math.Floor(sayi).ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			double sayi = Convert.ToDouble(textBox1.Text);
			label2.Text = Math.Pow(sayi,2).ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			double sayi = Convert.ToDouble(textBox1.Text);
			label2.Text = Math.Sqrt(sayi).ToString();
		}
	}
}
