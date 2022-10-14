using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomUygulaması
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
			int s1, s2, s3, top;
			s1 = rnd.Next(1, 8);
			s2 = rnd.Next(1, 8);
			s3 = rnd.Next(1, 8);
			label1.Text = s1.ToString();
			label2.Text = s2.ToString();
			label3.Text = s3.ToString();
			top = s1 + s2 + s3;
			label4.Text = top.ToString();


		}
	}
}
