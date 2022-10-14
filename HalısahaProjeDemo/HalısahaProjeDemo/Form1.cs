using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HalısahaProjeDemo
{
	public partial class Form1 : Form
	{
		void Sıfırla()
		{
			dolu1.Visible = false;
			bos1.Visible = true;
			dolu2.Visible = false;
			bos2.Visible = true;
			dolu3.Visible = false;
			bos3.Visible = true;
			dolu4.Visible = false;
			bos4.Visible = true;
			dolu5.Visible = false;
			bos5.Visible = true;
			dolu6.Visible = false;
			bos6.Visible = true;
			dolu7.Visible = false;
			bos7.Visible = true;
			dolu8.Visible = false;
			bos8.Visible = true;
			dolu9.Visible = false;
			bos9.Visible = true;
			dolu10.Visible = false;
			bos10.Visible = true;
			dolu11.Visible = false;
			bos11.Visible = true;
			dolu12.Visible = false;
			bos12.Visible = true;
			dolu13.Visible = false;
			bos13.Visible = true;
			dolu14.Visible = false;
			bos14.Visible = true;
			dolu15.Visible = false;
			bos15.Visible = true;
			dolu16.Visible = false;
			bos16.Visible = true;
			dolu17.Visible = false;
			bos17.Visible = true;
			dolu18.Visible = false;
			bos18.Visible = true;
			dolu19.Visible = false;
			bos19.Visible = true;
			dolu20.Visible = false;
			bos20.Visible = true;
			dolu21.Visible = false;
			bos21.Visible = true;
			dolu22.Visible = false;
			bos22.Visible = true;
			dolu23.Visible = false;
			bos23.Visible = true;
			dolu24.Visible = false;
			bos24.Visible = true;
			dolu25.Visible = false;
			bos25.Visible = true;
			dolu26.Visible = false;
			bos26.Visible = true;
			dolu27.Visible = false;
			bos27.Visible = true;
			dolu28.Visible = false;
			bos28.Visible = true;
			dolu29.Visible = false;
			bos29.Visible = true;
			dolu30.Visible = false;
			bos30.Visible = true;
			dolu31.Visible = false;
			bos31.Visible = true;
			dolu32.Visible = false;
			bos32.Visible = true;
			dolu33.Visible = false;
			bos33.Visible = true;
			dolu34.Visible = false;
			bos34.Visible = true;
			dolu35.Visible = false;
			bos35.Visible = true;
			dolu36.Visible = false;
			bos36.Visible = true;
			dolu37.Visible = false;
			bos37.Visible = true;
			dolu38.Visible = false;
			bos38.Visible = true;
			dolu39.Visible = false;
			bos39.Visible = true;
			dolu40.Visible = false;
			bos40.Visible = true;
			dolu41.Visible = false;
			bos41.Visible = true;
			dolu42.Visible = false;
			bos42.Visible = true;
			dolu43.Visible = false;
			bos43.Visible = true;
			dolu44.Visible = false;
			bos44.Visible = true;
			dolu45.Visible = false;
			bos45.Visible = true;
			dolu46.Visible = false;
			bos46.Visible = true;
			dolu47.Visible = false;
			bos47.Visible = true;
			dolu48.Visible = false;
			bos48.Visible = true;
			dolu49.Visible = false;
			bos49.Visible = true;
			dolu50.Visible = false;
			bos50.Visible = true;
			dolu51.Visible = false;
			bos51.Visible = true;
			dolu52.Visible = false;
			bos52.Visible = true;
			dolu53.Visible = false;
			bos53.Visible = true;
			dolu54.Visible = false;
			bos54.Visible = true;
			dolu55.Visible = false;
			bos55.Visible = true;
			dolu56.Visible = false;
			bos56.Visible = true;
			dolu57.Visible = false;
			bos57.Visible = true;
			dolu58.Visible = false;
			bos58.Visible = true;
			dolu59.Visible = false;
			bos59.Visible = true;
			dolu60.Visible = false;
			bos60.Visible = true;
			dolu61.Visible = false;
			bos61.Visible = true;
			dolu62.Visible = false;
			bos62.Visible = true;
			dolu63.Visible = false;
			bos63.Visible = true;
			dolu64.Visible = false;
			bos64.Visible = true;
			dolu65.Visible = false;
			bos65.Visible = true;
			dolu66.Visible = false;
			bos66.Visible = true;
			dolu67.Visible = false;
			bos67.Visible = true;
			dolu68.Visible = false;
			bos68.Visible = true;
			dolu69.Visible = false;
			bos69.Visible = true;
			dolu70.Visible = false;
			bos70.Visible = true;
			dolu71.Visible = false;
			bos71.Visible = true;
			dolu72.Visible = false;
			bos72.Visible = true;
			dolu73.Visible = false;
			bos73.Visible = true;
			dolu74.Visible = false;
			bos74.Visible = true;
			dolu75.Visible = false;
			bos75.Visible = true;
			dolu76.Visible = false;
			bos76.Visible = true;
			dolu77.Visible = false;
			bos77.Visible = true;
			dolu78.Visible = false;
			bos78.Visible = true;
			dolu79.Visible = false;
			bos79.Visible = true;
			dolu80.Visible = false;
			bos80.Visible = true;
			dolu81.Visible = false;
			bos81.Visible = true;
			dolu82.Visible = false;
			bos82.Visible = true;
			dolu83.Visible = false;
			bos83.Visible = true;
			dolu84.Visible = false;
			bos84.Visible = true;
			dolu85.Visible = false;
			bos85.Visible = true;
			dolu86.Visible = false;
			bos86.Visible = true;
			dolu87.Visible = false;
			bos87.Visible = true;
			dolu88.Visible = false;
			bos88.Visible = true;
			dolu89.Visible = false;
			bos89.Visible = true;
			dolu90.Visible = false;
			bos90.Visible = true;
			dolu91.Visible = false;
			bos91.Visible = true;
			dolu92.Visible = false;
			bos92.Visible = true;
			dolu93.Visible = false;
			bos93.Visible = true;
			dolu94.Visible = false;
			bos94.Visible = true;
			dolu95.Visible = false;
			bos95.Visible = true;
			dolu96.Visible = false;
			bos96.Visible = true;
			dolu97.Visible = false;
			bos97.Visible = true;
			dolu98.Visible = false;
			bos98.Visible = true;
			dolu99.Visible = false;
			bos99.Visible = true;
			dolu100.Visible = false;
			bos100.Visible = true;
			dolu101.Visible = false;
			bos101.Visible = true;
			dolu102.Visible = false;
			bos102.Visible = true;
			dolu103.Visible = false;
			bos103.Visible = true;
			dolu104.Visible = false;
			bos104.Visible = true;
			dolu105.Visible = false;
			bos105.Visible = true;
		}

		void KontrolEt()
		{
			if (cmbedtgun.Text == lblcntrlgun1.Text)
			{

				if (cmbedtsaat.Text == lblcntrl1.Text)
				{
					if (dolu1.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !"+MessageBoxButtons.OK+MessageBoxIcon.Information);
					}
					dolu1.Visible = true;
					bos1.Visible = false;

				}
				if (cmbedtsaat.Text == lblcntrl2.Text)
				{
					if (dolu2.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu2.Visible = true;
					bos2.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl3.Text)
				{
					if (dolu3.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu3.Visible = true;
					bos3.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl4.Text)
				{
					if (dolu4.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu4.Visible = true;
					bos4.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl5.Text)
				{
					if (dolu5.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu5.Visible = true;
					bos5.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl6.Text)
				{
					if (dolu6.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu6.Visible = true;
					bos6.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl7.Text)
				{
					if (dolu7.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu7.Visible = true;
					bos7.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl8.Text)
				{
					if (dolu8.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu8.Visible = true;
					bos8.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl9.Text)
				{
					if (dolu9.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu9.Visible = true;
					bos9.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl10.Text)
				{
					if (dolu10.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu10.Visible = true;
					bos10.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl11.Text)
				{
					if (dolu11.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu11.Visible = true;
					bos11.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl12.Text)
				{
					if (dolu12.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu12.Visible = true;
					bos12.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl13.Text)
				{
					if (dolu13.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu13.Visible = true;
					bos13.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl14.Text)
				{
					if (dolu14.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu14.Visible = true;
					bos14.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl15.Text)
				{
					if (dolu15.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu15.Visible = true;
					bos15.Visible = false;
				}
			}

			if (cmbedtgun.Text == lblcntrlgun2.Text)
			{
				if (cmbedtsaat.Text == lblcntrl1.Text)
				{
					if (dolu16.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu16.Visible = true;
					bos16.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl2.Text)
				{
					if (dolu17.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu17.Visible = true;
					bos17.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl3.Text)
				{
					if (dolu18.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu18.Visible = true;
					bos18.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl4.Text)
				{
					if (dolu19.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu19.Visible = true;
					bos19.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl5.Text)
				{
					if (dolu20.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu20.Visible = true;
					bos20.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl6.Text)
				{
					if (dolu21.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu21.Visible = true;
					bos21.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl7.Text)
				{
					if (dolu22.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu22.Visible = true;
					bos22.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl8.Text)
				{
					if (dolu23.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu23.Visible = true;
					bos23.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl9.Text)
				{
					if (dolu24.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu24.Visible = true;
					bos24.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl10.Text)
				{
					if (dolu25.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu25.Visible = true;
					bos25.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl11.Text)
				{
					if (dolu26.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu26.Visible = true;
					bos26.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl12.Text)
				{
					if (dolu27.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu27.Visible = true;
					bos27.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl13.Text)
				{
					if (dolu28.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu28.Visible = true;
					bos28.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl14.Text)
				{
					if (dolu29.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu29.Visible = true;
					bos29.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl15.Text)
				{
					if (dolu30.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu30.Visible = true;
					bos30.Visible = false;
				}
			}
			if (cmbedtgun.Text == lblcntrlgun3.Text)
			{
				if (cmbedtsaat.Text == lblcntrl1.Text)
				{
					if (dolu31.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu31.Visible = true;
					bos31.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl2.Text)
				{
					if (dolu32.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu32.Visible = true;
					bos32.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl3.Text)
				{
					if (dolu33.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu33.Visible = true;
					bos33.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl4.Text)
				{
					if (dolu34.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu34.Visible = true;
					bos34.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl5.Text)
				{
					if (dolu35.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu35.Visible = true;
					bos35.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl6.Text)
				{
					if (dolu36.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu36.Visible = true;
					bos36.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl7.Text)
				{
					if (dolu37.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu37.Visible = true;
					bos37.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl8.Text)
				{
					if (dolu38.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu38.Visible = true;
					bos38.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl9.Text)
				{
					if (dolu39.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu39.Visible = true;
					bos39.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl10.Text)
				{
					if (dolu40.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}

					dolu40.Visible = true;
					bos40.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl11.Text)
				{
					if (dolu41.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu41.Visible = true;
					bos41.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl12.Text)
				{
					if (dolu42.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu42.Visible = true;
					bos42.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl13.Text)
				{
					if (dolu43.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu43.Visible = true;
					bos43.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl14.Text)
				{
					if (dolu44.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu44.Visible = true;
					bos44.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl15.Text)
				{
					if (dolu45.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu45.Visible = true;
					bos45.Visible = false;
				}
			}
			if (cmbedtgun.Text == lblcntrlgun4.Text)
			{
				if (cmbedtsaat.Text == lblcntrl1.Text)
				{
					if (dolu46.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu46.Visible = true;
					bos46.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl2.Text)
				{
					if (dolu47.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu47.Visible = true;
					bos47.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl3.Text)
				{
					if (dolu48.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu48.Visible = true;
					bos48.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl4.Text)
				{
					if (dolu49.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu49.Visible = true;
					bos49.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl5.Text)
				{
					if (dolu50.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu50.Visible = true;
					bos50.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl6.Text)
				{
					if (dolu51.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu51.Visible = true;
					bos51.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl7.Text)
				{
					if (dolu52.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu52.Visible = true;
					bos52.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl8.Text)
				{
					if (dolu53.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu53.Visible = true;
					bos53.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl9.Text)
				{
					if (dolu54.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu54.Visible = true;
					bos54.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl10.Text)
				{
					if (dolu55.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu55.Visible = true;
					bos55.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl11.Text)
				{
					if (dolu56.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu56.Visible = true;
					bos56.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl12.Text)
				{
					if (dolu57.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu57.Visible = true;
					bos57.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl13.Text)
				{
					if (dolu58.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu58.Visible = true;
					bos58.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl14.Text)
				{
					if (dolu59.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu59.Visible = true;
					bos59.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl15.Text)
				{
					if (dolu60.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu60.Visible = true;
					bos60.Visible = false;
				}
			}
			if (cmbedtgun.Text == lblcntrlgun5.Text)
			{
				if (cmbedtsaat.Text == lblcntrl1.Text)
				{
					if (dolu61.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu61.Visible = true;
					bos61.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl2.Text)
				{
					if (dolu62.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu62.Visible = true;
					bos62.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl3.Text)
				{
					if (dolu63.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu63.Visible = true;
					bos63.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl4.Text)
				{
					if (dolu64.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu64.Visible = true;
					bos64.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl5.Text)
				{
					if (dolu65.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu65.Visible = true;
					bos65.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl6.Text)
				{
					if (dolu66.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu66.Visible = true;
					bos66.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl7.Text)
				{
					if (dolu67.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu67.Visible = true;
					bos67.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl8.Text)
				{
					if (dolu68.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu68.Visible = true;
					bos68.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl9.Text)
				{
					if (dolu69.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu69.Visible = true;
					bos69.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl10.Text)
				{
					if (dolu70.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu70.Visible = true;
					bos70.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl11.Text)
				{
					if (dolu71.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu71.Visible = true;
					bos71.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl12.Text)
				{
					if (dolu72.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu72.Visible = true;
					bos72.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl13.Text)
				{
					if (dolu73.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu73.Visible = true;
					bos73.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl14.Text)
				{
					if (dolu74.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu74.Visible = true;
					bos74.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl15.Text)
				{
					if (dolu75.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu75.Visible = true;
					bos75.Visible = false;
				}
			}
			if (cmbedtgun.Text == lblcntrlgun6.Text)
			{
				if (cmbedtsaat.Text == lblcntrl1.Text)
				{
					if (dolu76.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu76.Visible = true;
					bos76.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl2.Text)
				{
					if (dolu77.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu77.Visible = true;
					bos77.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl3.Text)
				{
					if (dolu78.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu78.Visible = true;
					bos78.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl4.Text)
				{
					if (dolu79.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu79.Visible = true;
					bos79.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl5.Text)
				{
					if (dolu80.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu80.Visible = true;
					bos80.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl6.Text)
				{
					if (dolu81.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu81.Visible = true;
					bos81.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl7.Text)
				{
					if (dolu82.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu82.Visible = true;
					bos82.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl8.Text)
				{
					if (dolu83.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu83.Visible = true;
					bos83.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl9.Text)
				{
					if (dolu84.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu84.Visible = true;
					bos84.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl10.Text)
				{
					if (dolu85.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu85.Visible = true;
					bos85.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl11.Text)
				{
					if (dolu86.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu86.Visible = true;
					bos86.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl12.Text)
				{
					if (dolu87.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu87.Visible = true;
					bos87.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl13.Text)
				{
					if (dolu88.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu88.Visible = true;
					bos88.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl14.Text)
				{
					if (dolu89.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu89.Visible = true;
					bos89.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl15.Text)
				{
					if (dolu90.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu90.Visible = true;
					bos90.Visible = false;
				}
			}
			if (cmbedtgun.Text == lblcntrlgun7.Text)
			{
				if (cmbedtsaat.Text == lblcntrl1.Text)
				{
					if (dolu91.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu91.Visible = true;
					bos91.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl2.Text)
				{
					if (dolu92.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu92.Visible = true;
					bos92.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl3.Text)
				{
					if (dolu93.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu93.Visible = true;
					bos93.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl4.Text)
				{
					if (dolu94.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu94.Visible = true;
					bos94.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl5.Text)
				{
					if (dolu95.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu95.Visible = true;
					bos95.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl6.Text)
				{
					if (dolu96.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu96.Visible = true;
					bos96.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl7.Text)
				{
					if (dolu97.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu97.Visible = true;
					bos97.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl8.Text)
				{
					if (dolu98.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu98.Visible = true;
					bos98.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl9.Text)
				{
					if (dolu99.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu99.Visible = true;
					bos99.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl10.Text)
				{
					if (dolu100.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu100.Visible = true;
					bos100.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl11.Text)
				{
					if (dolu101.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu101.Visible = true;
					bos101.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl12.Text)
				{
					if (dolu102.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu102.Visible = true;
					bos102.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl13.Text)
				{
					if (dolu103.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu103.Visible = true;
					bos103.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl14.Text)
				{
					if (dolu104.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu104.Visible = true;
					bos104.Visible = false;
				}
				if (cmbedtsaat.Text == lblcntrl15.Text)
				{
					if (dolu105.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
					}
					dolu105.Visible = true;
					bos105.Visible = false;
				}
			}
		}
		public Form1()
		{
			InitializeComponent();
		}

		BaglantiSinifDemo bgl = new BaglantiSinifDemo();

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9HI8MVE\\SQLEXPRESS;Initial Catalog=HalısahaProjeDemo;Integrated Security=True");

		
		private void Form1_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			conn.Close();

		}


		int tiklama_sayisi1 = 0;
		int tiklama_sayisi2 = 0;
		int tiklama_sayisi3 = 0;
		int tiklama_sayisi4 = 0;
		int tiklama_sayisi5 = 0;

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			SqlCommand komut = new SqlCommand("insert into Tbl_HalısahaProjeDemo (MusteriAD,MusteriSOYAD,MusteriTEL,RezerveTarih,RezerveSaat,SahaID) values (@m1,@m2,@m3,@m4,@m5,@m7)",conn);
			komut.Parameters.AddWithValue("@m1", txtad.Text);
			komut.Parameters.AddWithValue("@m2", txtsoyad.Text);
			komut.Parameters.AddWithValue("@m3", txttel.Text);
			komut.Parameters.AddWithValue("@m4", cmbedtgun.Text);
			komut.Parameters.AddWithValue("@m5", cmbedtsaat.Text);
			
			komut.Parameters.AddWithValue("@m7", cmbedtsaha.Text);
			komut.ExecuteNonQuery();
			

			

			if (cmbedtsaha.Text=="Saha1")
			{
                KontrolEt();
		    }
			
			if (cmbedtsaha.Text == "Saha2")
			{
				KontrolEt();
            }
			
			if (cmbedtsaha.Text == "Saha3")
			{
				KontrolEt();
            }
			
			if (cmbedtsaha.Text == "Saha4")
			{
			    KontrolEt();
		    }
			
			if (cmbedtsaha.Text == "Saha5")
			{
				KontrolEt();
            }
			conn.Close();

		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			tiklama_sayisi1++;
			if (tiklama_sayisi1 == 1)
			{
				Sıfırla();

			}
			conn.Close();
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			tiklama_sayisi2++;
			if (tiklama_sayisi2 == 1)
			{
				Sıfırla();

			}
			conn.Close();
			
		}

		private void simpleButton4_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			tiklama_sayisi3++;
			if (tiklama_sayisi3 == 1)
			{
				Sıfırla();

			}
			conn.Close();
		}

		private void simpleButton5_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			tiklama_sayisi4++;
			if (tiklama_sayisi4 == 1)
			{
				Sıfırla();

			}
			conn.Close();
			
		}

		private void simpleButton6_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			tiklama_sayisi5++;
			if (tiklama_sayisi5 == 1)
			{
				Sıfırla();

			}
			conn.Close();
		}
	}
	}

