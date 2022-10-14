using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetFılmProjesı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void kIRMIZIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Red;
		}

		private void sARIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Yellow;

		}

		private void mAVİToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.BlueViolet;
		}

		private void gRİToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Gray;
		}

		private void yEŞİLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.LightGreen;
		}

		private void pEMBEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.LightPink;
		}

		private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("BU PROJE ALİ İMRAN ATABEY TARAFINDAN YAPILDI" + "BİLGİ" + MessageBoxButtons.OK + MessageBoxIcon.Information);
		}

		private void bİLGİLERToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void uNDERGROUNDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=YLE85olJjp8");
			label1.Text = "6 UNDERGROUND";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ıLOVEYOUToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
			label1.Text = "I LOVE YOU";
		}

		private void oRGANİZEİŞLERSAZANSARMALIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=f5AkQJzvCgw");
			label1.Text = "ORGANİZE İŞLER (SAZAN SARMALI)";
		}

		private void yOLARKADAŞIM2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=75zplzpEHHc");
			label1.Text = "YOL ARKADAŞIM 2";
		}

		private void jOKERToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=zAGVQLHvwOY");
			label1.Text = "JOKER";
		}

		private void kOĞUŞTAKİMUCİZEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=z_tgY9Nmo18");
			label1.Text = "7.KOĞUŞTAKİ MUCİZE";
		}

		private void tHEPLATFORMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=RlfooqeZcdY");
			label1.Text = "THE PLATFORM";
		}

		private void bİRDBOXToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=o2AsIXSh2xo");
			label1.Text = "BIRD BOX";
		}

		private void dABBE4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=oFAHTz01f7g");
			label1.Text = "DABBE 4";
		}

		private void sİCCİN3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=rivB0DjQixs");
			label1.Text = "SİCCİN 4";
		}

		private void aQUToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=WDkg3h8PCVU");
			label1.Text = "AQUAMAN";
		}

		private void eVENGERSANDGAMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.youtube.com/watch?v=TcMBFSGVi1c");
			label1.Text = "AVENGER ANDGAME";
		}
	}
}
