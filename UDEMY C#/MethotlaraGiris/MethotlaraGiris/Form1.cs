using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethotlaraGiris
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void yazdir() {

			textBox1.Text = "ALİ İMRAN";
			textBox2.Text = "ATABEY";
			textBox3.Text = "MALATYA";
			textBox4.Text = "19";


		}
		void renklendir()
		{
			textBox1.BackColor = Color.Yellow;
			textBox2.BackColor = Color.Red;
			textBox3.BackColor = Color.Yellow;
			textBox4.BackColor = Color.Blue;
		}

		private void temizle()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox1.Focus();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			yazdir();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			renklendir();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			temizle();
		}
	}
}
