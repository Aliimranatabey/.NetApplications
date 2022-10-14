using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Grafık
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			chart1.Series["KİTAP"].Points.AddXY("AKDANİZ" , 5);
			chart1.Series["KİTAP"].Points.AddXY("EGE" , 8);
			chart1.Series["KİTAP"].Points.AddXY("MARMARA" , 10);
			chart1.Series["KİTAP"].Points.AddXY("İÇ ANADOLU" , 3);
			chart1.Series["KİTAP"].Points.AddXY("DOĞU ANADOLU" , 2);
			chart1.Series["KİTAP"].Points.AddXY("GÜNEYDOĞU ANADOLU" , 1);
			chart1.Series["KİTAP"].Points.AddXY("KARADENİZ" , 4);
		}
	}
}
