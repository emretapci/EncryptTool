using System;
using System.IO;
using System.Security.Cryptography;
using Encrypt.Algorithm.BlowFish;
using Encrypt.Algorithm.Serpent;
using Encrypt.Algorithm.TwoFish;

namespace Encrypt
{
	internal enum CipherAlgorithm
	{
		AES128,
		AES256,
		TwoFish128,
		BlowFish256,
		Serpent128
	}

	static class EncDec
	{
		private static bool run;

		internal static event Action<int> Processed;

		//If encrypt is true, encrypts the given file into a new file in the same folder with name ".enc" appended.
		//If encrypt is false, decrypts the given file into a new file in the same folder with name ".dec" appended.
		internal static void EncryptOrDecrypt(CipherAlgorithm ca, string inputFile, string outputFile, string encryptionKey, bool encrypt)
		{
			run = true;
			using (SymmetricAlgorithm encryptor = CreateCipher(ca, encryptionKey))
			{
				byte[] buffer = new byte[1024];

				using (FileStream inputFs = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
				using (FileStream outputFs = new FileStream(outputFile, FileMode.CreateNew))
				using (CryptoStream cs = new CryptoStream(outputFs, encrypt ? encryptor.CreateEncryptor() : encryptor.CreateDecryptor(), CryptoStreamMode.Write))
				{
					int bytesRead;
					while (run && (bytesRead = inputFs.Read(buffer, 0, 1024)) > 0)
					{
						cs.Write(buffer, 0, bytesRead);
						Processed(bytesRead);
					}
				}
			}

			if (!run)
			{
				File.Delete(outputFile);
			}

			run = false;
		}

		internal static void Cancel()
		{
			run = false;
		}

		private static SymmetricAlgorithm CreateCipher(CipherAlgorithm ca, string encryptionKey)
		{
			SymmetricAlgorithm sa = null;

			Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[]
				{ 21, 221, 125, 99, 18, 200, 181, 116, 158, 30, 180, 73, 108 });

			switch (ca)
			{
				case CipherAlgorithm.AES128:
					sa = Aes.Create();
					break;
				case CipherAlgorithm.AES256:
					sa = Aes.Create();
					break;
				case CipherAlgorithm.TwoFish128:
					sa = new Twofish();
					break;
				case CipherAlgorithm.BlowFish256:
					sa = new BlowFish();
					break;
				case CipherAlgorithm.Serpent128:
					sa = new SerpentEngine();
					break;
			}

			sa.Key = pdb.GetBytes(sa.KeySize / 8);
			sa.IV = pdb.GetBytes(sa.BlockSize / 8);

			return sa;
		}
	}
}
