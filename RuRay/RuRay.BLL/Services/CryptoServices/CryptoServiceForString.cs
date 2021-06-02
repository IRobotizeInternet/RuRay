using System;
using System.Security.Cryptography;
using System.Text;
using RuRayFacebook.CryptoServices;

namespace RuRayFacebook.Security
{
    public class CryptoServiceForString : Crypto
    {
        private byte[] _inputArray { get; set; }
        private AesCryptoServiceProvider _cryptoServiceProvider { get; set; }

        public string CryptoKey { get; set; }
        public string Value { get; set; }

        public CryptoServiceForString()
        {
            InitalizeCrypto();
        }

        /// <summary>
        /// Privide encryption for a given cryptoKey and valueToEncrypt
        /// </summary>
        /// <returns>Decrypted value</returns>
        public override string EncryptValue => Transform(_cryptoServiceProvider.CreateEncryptor());

        /// <summary>
        /// Privide decryption for a given cryptoKey and valueToDecrypt
        /// </summary>
        /// <returns>Decrypted value</returns>
        public override string DecryptValue => Transform(_cryptoServiceProvider.CreateDecryptor());

        private string Transform(ICryptoTransform cryptoTransform)
        {
            var transformedBlock = cryptoTransform.TransformFinalBlock(_inputArray, 0, _inputArray.Length);
            return Encoding.UTF8.GetString(transformedBlock);
        }

        private void InitalizeCrypto()
        {
            _inputArray = Convert.FromBase64String(Value ?? string.Empty);

            // Initialize crypto service.
            _cryptoServiceProvider = new AesCryptoServiceProvider
            {
                Mode = CipherMode.ECB,
                Padding = PaddingMode.ISO10126,
                Key = Encoding.UTF32.GetBytes(CryptoKey ?? string.Empty)
            };
        }

        /// <summary>
        /// Never call this function, it used to generate AESKey. 
        /// This key will be stored in the App.config file. Calling this 
        /// function will cause key to overriten.
        /// </summary>
        /// <returns></returns>
        public static string GetAesKey => Encoding.UTF8.GetString(Aes.Create().Key);
    }
}
