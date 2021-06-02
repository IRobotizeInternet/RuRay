using System;
using System.Security.Cryptography;
using System.Text;
using RuRayFacebook.CryptoServices;

namespace RuRayFacebook.Security
{
    /// <summary>
    /// Defines the <see cref="CryptoServiceForString" />.
    /// </summary>
    public class CryptoServiceForString : Crypto
    {
        /// <summary>
        /// Gets or sets the _inputArray.
        /// </summary>
        private byte[] _inputArray { get; set; }

        /// <summary>
        /// Gets or sets the _cryptoServiceProvider.
        /// </summary>
        private AesCryptoServiceProvider _cryptoServiceProvider { get; set; }

        /// <summary>
        /// Gets or sets the CryptoKey.
        /// </summary>
        public string CryptoKey { get; set; }

        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoServiceForString"/> class.
        /// </summary>
        public CryptoServiceForString()
        {
            InitalizeCrypto();
        }

        /// <summary>
        /// Gets the EncryptValue
        /// Privide encryption for a given cryptoKey and valueToEncrypt.
        /// </summary>
        public override string EncryptValue => Transform(_cryptoServiceProvider.CreateEncryptor());

        /// <summary>
        /// Gets the DecryptValue
        /// Privide decryption for a given cryptoKey and valueToDecrypt.
        /// </summary>
        public override string DecryptValue => Transform(_cryptoServiceProvider.CreateDecryptor());

        /// <summary>
        /// The Transform.
        /// </summary>
        /// <param name="cryptoTransform">The cryptoTransform<see cref="ICryptoTransform"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private string Transform(ICryptoTransform cryptoTransform)
        {
            var transformedBlock = cryptoTransform.TransformFinalBlock(_inputArray, 0, _inputArray.Length);
            return Encoding.UTF8.GetString(transformedBlock);
        }

        /// <summary>
        /// The InitalizeCrypto.
        /// </summary>
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
        /// Gets the GetAesKey
        /// Never call this function, it used to generate AESKey. 
        /// This key will be stored in the App.config file. Calling this 
        /// function will cause key to overriten..
        /// </summary>
        public static string GetAesKey => Encoding.UTF8.GetString(Aes.Create().Key);
    }
}
