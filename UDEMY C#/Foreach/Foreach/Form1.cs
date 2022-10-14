using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int j = 0;
			int kactane = 0;
			int toplam = 0;
			int[] sayilar = { 4, 8, 12, 16, 20, 25, 23, 45, 44, 56, 67, 78 };
			foreach (int i in sayilar)
			{
				
				
					if (sayilar[j]%4== 0)
					{
						listBox1.Items.Add(sayilar[j].ToString());
					j++;
						
					}


				
			}
			
		
			
		}
	}
}
