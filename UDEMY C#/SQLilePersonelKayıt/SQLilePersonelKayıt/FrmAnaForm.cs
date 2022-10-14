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
	public partial class FrmAnaForm : Form
	{
		public FrmAnaForm()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9HI8MVE\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

		void temizle()
		{
			txtpersonelıd.Text="";
			txtpersonelad.Text = "";
			txtpersonelsoyad.Text = "";
			cmbsehir.Text = "";
			mskmaas.Text = "";
			txtmeslek.Text = "";
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			txtpersonelad.Focus();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'personelVeriTabaniDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

		}

		private void btnlistele_Click(object sender, EventArgs e)
		{
			this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
		}

		private void btnkaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaaş,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
			komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
			komut.Parameters.AddWithValue("@p2", txtpersonelsoyad.Text);
			komut.Parameters.AddWithValue("@p3", cmbsehir.Text);
			komut.Parameters.AddWithValue("@p4", mskmaas.Text);
			komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
			komut.Parameters.AddWithValue("@p6", label8.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("PERSONEL EKLENDİ");
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (label8.Text == "True")
			{
				radioButton1.Checked = true;
			}


		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (label8.Text == "False")
			{
				radioButton2.Checked = true;
			}

		}

		private void btntemizle_Click(object sender, EventArgs e)
		{
			temizle();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;

			txtpersonelıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			txtpersonelad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			txtpersonelsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			cmbsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			mskmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
			txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
			
		}

		private void label8_TextChanged(object sender, EventArgs e)
		{
			if (label8.Text == "True")
			{
				radioButton1.Checked = true;
			}
			if (label8.Text == "False")
			{
				radioButton2.Checked = true;
			}
		}

		private void btnsil_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where PerID=@k1",baglanti);
			komutsil.Parameters.AddWithValue("@k1",txtpersonelıd.Text);
			komutsil.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("KOMUT SİLİNDİ");
		}

		private void btngüncelle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaaş=@a4,PerDurum=@a5,PerMeslek=@a6 where PerID=@a7", baglanti);
			komutguncelle.Parameters.AddWithValue("@a1",txtpersonelad.Text);
			komutguncelle.Parameters.AddWithValue("@a2", txtpersonelsoyad.Text);
			komutguncelle.Parameters.AddWithValue("@a3", cmbsehir.Text);
			komutguncelle.Parameters.AddWithValue("@a4", mskmaas.Text);
			komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
			komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
			komutguncelle.Parameters.AddWithValue("@a7", txtpersonelıd.Text);
			komutguncelle.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("PERSONEL BİLGİ GÜNCELLENDİ");
		}

		private void btnistatistik_Click(object sender, EventArgs e)
		{
			Frmistatistikcs fr = new Frmistatistikcs();
			fr.Show();
		}

		private void btngrafikler_Click(object sender, EventArgs e)
		{
			Frmgrafikler frg = new Frmgrafikler();
			frg.Show();
		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}
	}
}
