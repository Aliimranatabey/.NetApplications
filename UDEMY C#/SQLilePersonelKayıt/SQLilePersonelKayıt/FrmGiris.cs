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
	public partial class FrmGiris : Form
	{
		public FrmGiris()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9HI8MVE\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From Tbl_Yönetici where KullaniciAdi=@p1 and Sifre=@p2",baglanti);
			komut.Parameters.AddWithValue("@p1",txtkullaniciadi.Text);
			komut.Parameters.AddWithValue("@p2",txtsifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if (dr.Read())
			{
				FrmAnaForm frm = new FrmAnaForm();
				frm.Show();
				this.Hide();

			}
			else
			{
				MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");

			}
			baglanti.Close();

		}
	}
}
