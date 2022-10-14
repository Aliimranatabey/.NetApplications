using System;
using System.IO;
using System.Security.Cryptography;

namespace AesAlgorithm
{
	class Program
	{
		static void Main(string[] args)
		{
			string original = "sifrelenecek mesaj";
			Console.WriteLine("Sifrelenecem Mesaji Giriniz =>> ");
			original = Console.ReadLine();

			using (Aes myAes = Aes.Create())
			{
				byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);
				string roundtrip = DescryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);
				Console.WriteLine("sifrelenecek mesaj==>> {0}", original);
				Console.Write("\n sifrelenmis mesaj==>>");

				for (int i = 0; i < encrypted.Length; i++)
				{
					Console.Write(encrypted[i] + "|");
				}
				Console.WriteLine("\n sifrelenmis mesajın cozümlenmis hali : {0}", roundtrip);
			}
			Console.ReadKey();
		}
		static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
		{
			if (plainText == null || plainText.Length <= 0)
				throw new ArgumentNullException("plainText");
			if (Key == null || Key.Length <= 0)
				throw new ArgumentNullException("Key");
			if (IV == null || IV.Length <= 0)
				throw new ArgumentNullException("IV");
			byte[] encrypted;
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Key;
				aesAlg.IV = IV;

				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
				using (MemoryStream msEncrypt = new MemoryStream())
				{
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							swEncrypt.Write(plainText);
						}
						encrypted = msEncrypt.ToArray();
					}
				}
				return encrypted;
			}
		}
		static string DescryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
		{
			if (cipherText == null || cipherText.Length <= 0)
				throw new ArgumentNullException("cipherText");
			if (Key == null || Key.Length <= 0)
				throw new ArgumentNullException("Key");
			if (IV == null || IV.Length <= 0)
				throw new ArgumentNullException("IV");

			string plainText = null;
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Key;
				aesAlg.IV = IV;
				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

				using (MemoryStream msDecrypt = new MemoryStream(cipherText))
				{
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))
						{
							plainText = srDecrypt.ReadToEnd();
						}
					}
				}
				return plainText;
			}
		}
	}
}
