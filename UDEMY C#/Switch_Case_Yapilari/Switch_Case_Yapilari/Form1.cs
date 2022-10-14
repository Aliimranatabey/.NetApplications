using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Yapilari
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int ay = Convert.ToInt16(textBox1.Text);
			switch (ay)
			{
				case 1:label3.Text = "Ocak";break;
				case 2: label3.Text = "Şubat"; break;
				case 3: label3.Text = "Mart"; break;
				case 4: label3.Text = "Nisan"; break;
				case 5: label3.Text = "Mayıs"; break;
				case 6: label3.Text = "Haziran"; break;
				case 7: label3.Text = "Temmuz"; break;
				case 8: label3.Text = "Ağustos"; break;
				case 9: label3.Text = "Eylül"; break;
				case 10: label3.Text = "Ekim"; break;
				case 11: label3.Text = "Kasım"; break;
				case 12: label3.Text = "Aralık"; break;
				default:label3.Text = "Hatalı Ay";break;

			}
		}
	}
}
