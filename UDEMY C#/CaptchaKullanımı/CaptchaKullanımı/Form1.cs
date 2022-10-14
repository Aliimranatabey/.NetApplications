using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaKullanımı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			

			if (textBox1.Text == label1.Text)
			{
				MessageBox.Show("BAŞARILI");
			}
			else
			{
				MessageBox.Show("BAŞARISIZ");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string[] sembol1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "W", "X", "Z" };
			string[] sembol2 = { "+", "-", "*", "/", "!", "#" };

			Random rnd = new Random();
			int s1, s2, s3, s4, s5;
			s1 = rnd.Next(0, sembol1.Length);
			s2 = rnd.Next(0, sembol2.Length);
			s3 = rnd.Next(0, sembol1.Length);
			s4 = rnd.Next(0, sembol2.Length);
			s5 = rnd.Next(1, 10);

			label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol1[s3].ToString() + sembol2[s4].ToString() + s5.ToString();
		}
	}
}
