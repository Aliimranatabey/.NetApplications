using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiVeriGecisi
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		public string mesaj;
		public string futbolcu;
		public string isim;
		private void Form2_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add(isim);
			comboBox2.Items.Add(mesaj);
			comboBox3.Items.Add(futbolcu);
		}
	}
}
