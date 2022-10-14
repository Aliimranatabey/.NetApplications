using System;

namespace Ödev1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bir Sayı Giriniz");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Bir Sayı Giriniz");
			int b = Convert.ToInt32(Console.ReadLine());

			int x = a + b;//toplama
			Console.WriteLine(x);
			float ondalıklı=15.3f;
			double ondalıklı2=18.75;
			int c = (int)ondalıklı2;//Bilinçli Tür Dönüşümü
			float z = a - b;//çıkarma
			Console.WriteLine(z);
		    float d = ondalıklı; //Bilinçsiz Tür Dönüşümü
			double y = b / (float)a;//bölme
			Console.WriteLine(y);
			double k = c * d;//çarpma
			Console.WriteLine(k);
			
			string metin = "45";
			string metin2 = "458";
			int tamsayı = int.Parse(metin);//Parse dönüşümü
			float ondalıklı3 = float.Parse(metin2);
			Console.WriteLine(tamsayı);
			Console.WriteLine(ondalıklı3);

			int tamsayı2 = 456;
			string metin3 = tamsayı2.ToString();
			Console.WriteLine("Bu bir string ifadesidir :"+metin3);//ToString Dönüşümü
			Console.ReadKey();









		}
	}
}
