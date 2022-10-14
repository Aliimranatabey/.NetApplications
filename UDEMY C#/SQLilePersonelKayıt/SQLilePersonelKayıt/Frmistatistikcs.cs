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
	public partial class Frmistatistikcs : Form
	{
		public Frmistatistikcs()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9HI8MVE\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
		private void Frmistatistikcs_Load(object sender, EventArgs e)
		{
			//toplam personel
			baglanti.Open();
			SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
			SqlDataReader dr1 = komut1.ExecuteReader();
			while (dr1.Read())
			{
				lbltoplampersonel.Text = dr1[0].ToString();
			}
			baglanti.Close();

			//evli personel
			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=1", baglanti);
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				lblevlipersonel.Text = dr2[0].ToString();
			}
			baglanti.Close();

			//bekar personel
			baglanti.Open();
			SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where Perdurum=0", baglanti);
			SqlDataReader dr3 = komut3.ExecuteReader();
			while (dr3.Read())
			{
				lblbekarpersonel.Text = dr3[0].ToString();
			}
			baglanti.Close();

			//toplam şehir sayısı
			baglanti.Open();
			SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel",baglanti);
			SqlDataReader dr4 = komut4.ExecuteReader();
			while (dr4.Read())
			{
				lblsehirsayisi.Text = dr4[0].ToString();
			}
			baglanti.Close();

			//toplam maaş
			baglanti.Open();
			SqlCommand komut5 = new SqlCommand("Select Sum(PerMaaş) From Tbl_Personel", baglanti);
			SqlDataReader dr5 = komut5.ExecuteReader();
			while (dr5.Read())
			{
				lbltoplammaas.Text = dr5[0].ToString();
			}
			baglanti.Close();

			//ortalama maaş
			baglanti.Open();
			SqlCommand komut6 = new SqlCommand("Select Avg(PerMaaş)From Tbl_Personel", baglanti);
			SqlDataReader dr6 = komut6.ExecuteReader();
			while (dr6.Read())
			{
				lblortalamamaas.Text = dr6[0].ToString();
			}
			baglanti.Close();
		}
	}
}
