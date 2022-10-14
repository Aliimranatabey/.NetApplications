using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLotoUygulaması
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int h1, h2, h3, h4, h5;
			h1 = rnd.Next(1, 10);
			h2 = rnd.Next(1, 10);
			h3 = rnd.Next(1, 10);
			h4 = rnd.Next(1, 10);
			h5 = rnd.Next(1, 10);
			label1.Text = h1.ToString();
			label2.Text = h2.ToString();
			label3.Text = h3.ToString();
			label4.Text = h4.ToString();
			label5.Text = h5.ToString();

			if (textBox1.Text == h1.ToString())
			{
				textBox1.BackColor = Color.Green;
			}
			else
			{
				textBox1.BackColor = Color.Red;
			}
			if (textBox2.Text == h2.ToString())
			{
				textBox2.BackColor = Color.Green;
			}
			else
			{
				textBox2.BackColor = Color.Red;
			}
			if (textBox3.Text == h3.ToString())
			{
				textBox3.BackColor = Color.Green;
			}
			else
			{
				textBox3.BackColor = Color.Red;
			}
			if (textBox4.Text == h4.ToString())
			{
				textBox4.BackColor = Color.Green;
			}
			else
			{
				textBox4.BackColor = Color.Red;
			}
			if (textBox5.Text == h5.ToString())
			{
				textBox5.BackColor = Color.Green;
			}
			else
			{
				textBox5.BackColor = Color.Red;
			}

		}
	}
}
