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

namespace SQLilePersonelKayıt
{
	public partial class Frmgrafikler : Form
	{
		public Frmgrafikler()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9HI8MVE\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
		private void Frmgrafikler_Load(object sender, EventArgs e)
		{
			//grafik1

			baglanti.Open();
			SqlCommand komutg1 = new SqlCommand("Select Persehir,Count(*) From Tbl_Personel Group By PerSehir",baglanti);
			SqlDataReader dr1 = komutg1.ExecuteReader();
			while (dr1.Read())
			{
				chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
			}
			baglanti.Close();

			//grafik2

			baglanti.Open();
			SqlCommand komutg2 = new SqlCommand("Select PerMeslek,Avg(PerMaaş) From Tbl_Personel Group By PerMeslek", baglanti);
			SqlDataReader dr2 = komutg2.ExecuteReader();
			while (dr2.Read())
			{
				chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
			}
			baglanti.Close();

		}
	}
}
