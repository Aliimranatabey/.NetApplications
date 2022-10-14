using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriyeDegerDöndürenMethotlar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int carpim(int s1,int s2,int s3)
		{
			int carpimlari = s1 * s2 * s3;
			return carpimlari;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = carpim(4, 2, 8).ToString();
			label2.Text = carpim(2, 3, 6).ToString();
			label3.Text = carpim(1, 1, 0).ToString();
		}
	}
}
