using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİLGİYARİSMASİ
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int soruno = 0, dogru = 0, yanlis = 0;

		private void btnB_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			button1.Enabled = true;

			label5.Text = btnB.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				lbldogru.Text = dogru.ToString();
				pictureBox1.Visible = true;

			}
			else
			{
				yanlis++;
				lblyanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}

		}

		private void btnC_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			button1.Enabled = true;

			label5.Text = btnC.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				lbldogru.Text = dogru.ToString();
				pictureBox1.Visible = true;

			}
			else
			{
				yanlis++;
				lblyanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}

		}

		private void btnD_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			button1.Enabled = true;

			label5.Text = btnD.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				lbldogru.Text = dogru.ToString();
				pictureBox1.Visible = true;

			}
			else
			{
				yanlis++;
				lblyanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}

		}

		private void btnA_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			button1.Enabled = true;

			label5.Text = btnA.Text;
			if (label4.Text == label5.Text)
			{
				dogru++;
				lbldogru.Text = dogru.ToString();
				pictureBox1.Visible = true;

			}
			else
			{
				yanlis++;
				lblyanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{

			btnA.Enabled = true;
			btnB.Enabled = true;
			btnC.Enabled = true;
			btnD.Enabled = true;
			button1.Enabled = false;
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			soruno++;
			lblsoruno.Text = soruno.ToString();

			if (soruno == 1)
			{
				richTextBox1.Text = "Dünyanın En Saçma Uygulaması Hangisidir ?";
				btnA.Text = "INSTAGRAM";
				btnB.Text = "TWITTER";
				btnC.Text = "YOUTUBE";
				btnD.Text = "TIKTOK";
				label4.Text = "TIKTOK";
			}
			if (soruno == 2)
			{
				richTextBox1.Text = "Alim Hamza Tayın En Sevidiği Fenomen Kimdir ?";
				btnA.Text = "UNLOST";
				btnB.Text = "ENES BATUR";
				btnC.Text = "CEMRE SOLMAZ";
				btnD.Text = "REYNMEN";
				label4.Text = "CEMRE SOLMAZ";
			}
			if (soruno == 3)
			{
				richTextBox1.Text = "Batuhan Sayın ve Molon kimden daha kötü oyuncudur ?";
				btnA.Text = "ALİ İMRAN ATABEY";
				btnB.Text = "HASAN IŞIK";
				btnC.Text = "MUSTO MEŞE";
				btnD.Text = "ALİM HAMZA TAY";
				label4.Text = "ALİ İMRAN ATABEY";

			}
			if(soruno==4)
			{
				richTextBox1.Text = "Türkiyeye gelen gelmiş geçmiş en kral futbolcu kimdir ?  ";
				btnA.Text = "HAGI";
				btnB.Text = "RICARDO QUARESMA";
				btnC.Text = "ALEX";
				btnD.Text = "DROGBA";
				label4.Text = "RICARDO QUARESMA";
			}
			if(soruno==5)
			{
				richTextBox1.Text = "Kurtlar Vadisi Çakır hangi bölümde ölmüştür ?";
				btnA.Text = "42";
				btnB.Text = "43";
				btnC.Text = "44";
				btnD.Text = "43te vuruluyo 45te ölüyo";
				label4.Text = "43te vuruluyo 45te ölüyo";
			}
			if (soruno == 6)
			{
				btnA.Enabled = false;
				btnB.Enabled = false;
				btnC.Enabled = false;
				btnD.Enabled = false;
				button1.Enabled = false;
				MessageBox.Show("DOĞRU : " + dogru + "\n" + "YANLIŞ : " + yanlis);
			}
		}
	}
}
