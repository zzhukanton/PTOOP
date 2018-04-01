using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Helpers
{
    public class AesEncryptionUtility
    {
        private readonly string _password;
        private byte[] _keyVector;
        private byte[] _ivVector;

        private const int AesKeySize = 256;
        private const int AesBlockSize = 128;

        public AesEncryptionUtility() : this("AesKey")
        {
        }

        private void InitUtility()
        {
            var saltBytes = new byte[]{ 1, 2, 1, 4, 0, 5, 5, 6 };
            byte[] passwordBytes = Encoding.UTF8.GetBytes(_password);

            // Hash the password with SHA256
            SHA256.Create().ComputeHash(passwordBytes);

            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

            _keyVector = key.GetBytes(AesKeySize / 8);
            _ivVector = key.GetBytes(AesBlockSize / 8);
        }

        public AesEncryptionUtility(string password)
        {
            _password = password ?? Guid.NewGuid().ToString();

            InitUtility();
        }

        public TObject Decrypt<TObject>(TObject encryptionObject)
        {
            throw new NotImplementedException();
        }

        public TObject Encrypt<TObject>(TObject encryptionObject)
        {
            throw new NotImplementedException();
        }

        public string Password => _password;

        public string Encrypt(string encryptionString)
        {
            return EncryptText(encryptionString);
        }

        private string EncryptText(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }

        private string DecryptText(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
        
        private byte[] AES_Operation(byte[] bytesToBeOperated, Func<RijndaelManaged, ICryptoTransform> cryptoTransform)
        {
            byte[] encryptedBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    aes.KeySize = AesKeySize;
                    aes.BlockSize = AesBlockSize;
                    
                    aes.Key = _keyVector;
                    aes.IV = _ivVector;

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, cryptoTransform(aes), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeOperated, 0, bytesToBeOperated.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        private byte[] AES_Encrypt(byte[] bytesToBeEncrypted)
        {
            return AES_Operation(bytesToBeEncrypted, aes => aes.CreateEncryptor());
        }
        
        private byte[] AES_Decrypt(byte[] bytesToBeDecrypted)
        {
            return AES_Operation(bytesToBeDecrypted, aes => aes.CreateDecryptor());
        }

        public string Decrypt(string encryptionString)
        {
            return DecryptText(encryptionString);
        }
        
        public void Dispose()
        {
            Dispose(true);
        }

        ~AesEncryptionUtility()
        {
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {

        }
    }
}