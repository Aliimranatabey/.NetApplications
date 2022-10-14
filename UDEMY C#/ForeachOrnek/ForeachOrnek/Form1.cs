using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeachOrnek
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i = 1;
			int kactane = 0;
			int toplam = 0;
			int[] sayilar = { 4, 8, 12, 16, 20, 33, 34, 35, 75, 99, 44, 48 };
			foreach(int x in sayilar)
			{
				if (x % 4 == 0)
				{
					listBox1.Items.Add(x);
					kactane = kactane + i;
					toplam = toplam + x;

					
				}
			}
			label3.Text = toplam.ToString();
			label4.Text = kactane.ToString();
			

		}
	}
}
