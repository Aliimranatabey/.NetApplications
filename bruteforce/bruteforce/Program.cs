using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruteforce
{
	class Program
	{
		public object Page { get; private set; }
		public object Session { get; private set; }

		static void Main(string[] args)
		{

		}
		protected void Page_Load(object sender, EventArgs e)
		{
			//İlk yüklemede doğrulama kodunu oluşturur.
			if (!Page.IsPostBack)
			{
				ResimOlustur();
			}
		}

		public void ResimOlustur()
		{
			string kod = "";
			kod = RastgeleVeriUret();
			//Üretilen kodu Session nesnesine aktarır.
			Session.Add("kod", kod);
			//Rastgele üretilen metini alıp resme dönüştürelim.
			//boş bir resim dosyası oluştur.
			Bitmap bmp = new Bitmap(100, 21);
			//Graphics sınıfı ile resmin kontrolunu alır.
			Graphics g = Graphics.FromImage(bmp);
			//DrawString 20‘ye 0 kordinatına kodu‘u yazdırır.
			g.DrawString(kod, new Font("Comic Sanns MS", 15), new SolidBrush(Color.Black), 20, 0);
			//Resmi binary olarak alıp sayfaya yazdırmak ıcın MemoryStream kullandık.
			MemoryStream ms = new MemoryStream();
			bmp.Save(ms, ImageFormat.Png);
			var base64Data = Convert.ToBase64String(ms.ToArray());
			imgKod.ImageUrl = "data:image/png;base64," + base64Data;
			g.Dispose();
			bmp.Dispose();
			ms.Close();
			ms.Dispose();
		}

		public string RastgeleVeriUret()
		{
			string deger = "";
			//Türkçe karakterleri kullanmaktan vazgeçtim.
			string dizi = "ABCDEFGHIJKLMNOPRSTUVYZ0123456789";
			Random r = new Random();
			//Toplam 6 karakterden oluşan rastgele bir metin oluşturalım.
			for (int i = 0; i < 5; i++)
			{
				deger = deger + dizi[r.Next(0, 33)];
			}
			return deger;
		}

		protected void btnKontrol_Click(object sender, EventArgs e)
		{
			//Bu kısımda da Session'daki değer ile kullanıcının resimde görerek girdiği kod karşılaştırılır.
			if (txtKontrolKodu.Text == Session["kod"].ToString())
			{
				//Doğrulama kodu doğruysa çalıştırılacak kodlar
				lblMesaj.Text = "Doğrulama Sağlandı!";
			}
			else
			{
				//Doğrulama kodu yanlışsa çalıştırılacak kodlar
				lblMesaj.Text = "Doğrulama Kodu Yanlış!";
				//Kullanıcının girdiği kod yanlışsa yeni bir resim ve session oluşturulur.
				ResimOlustur();
			}
		}
	}
}
