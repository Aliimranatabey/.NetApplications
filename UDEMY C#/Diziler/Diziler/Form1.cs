using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double[] ondalikli = { 0.1, 0.3, 1.4, 4.8, 6.7, 7.3, 8.4 };
			label1.Text = ondalikli[4].ToString();

			char[] harfler = { 'A', 'B', 'C', 'D', 'E', 'N', 'I', 'Z' };
			label2.Text = harfler[3].ToString();
		}
	}
}
