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

namespace HalısahaProjeÖdevi
{
	public partial class Form1 : Form
	{
		void KontrolEt()
		{
			if (cmbedtgun.Text == lblcntrlgun1.Text)
			{

				if (cmbedtsaat.Text == lblcntrl1.Text)
				{
					if (dolu1.Created == true)
					{
						MessageBox.Show("REZERVE EDİLDİ !" + MessageBoxButtons.OK + MessageBoxIcon.Information);
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

		BaglantiSinif bgl = new BaglantiSinif();

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9HI8MVE\\SQLEXPRESS;Initial Catalog=HalısahaProjeÖdevi;Integrated Security=True");


		private void Form1_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			conn.Close();


		}


		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			

			SqlCommand komut = new SqlCommand("insert into Tbl_HalısahaProje (SahaID,MusteriAD,MusteriSOYAD,MusteriTEL,RezerveGUN,RezerveSAAT) values (@m1,@m2,@m3,@m4,@m5,@m6)",conn);
			komut.Parameters.AddWithValue("@m1", cmbedtsaha.Text);
			komut.Parameters.AddWithValue("@m2", txtad.Text);
			komut.Parameters.AddWithValue("@m3", txtsoyad.Text);
			komut.Parameters.AddWithValue("@m4", txttel.Text);
			komut.Parameters.AddWithValue("@m5", cmbedtgun.Text);
			komut.Parameters.AddWithValue("@m6", cmbedtsaat.Text);

			
			komut.ExecuteNonQuery();



			if (cmbedtsaha.Text == "Saha1")
			{
				KontrolEt();
			}


			conn.Close();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(bgl.Adres);
			conn.Open();
			
			cmbedtsaha.Text = "";
			txtad.Text = "";
			txtsoyad.Text = "";
			txtsoyad.Text = "";
			txttel.Text = "";
			cmbedtgun.Text = "";
			cmbedtsaat.Text = "";

			conn.Close();
		}
	}
}
