namespace RuRayFacebook.CryptoServices
{
    /// <summary>
    /// Defines the <see cref="Crypto" />.
    /// </summary>
    public abstract class Crypto
    {
        /// <summary>
        /// Gets the EncryptValue.
        /// </summary>
        public abstract string EncryptValue { get; }

        /// <summary>
        /// Gets the DecryptValue.
        /// </summary>
        public abstract string DecryptValue { get; }
    }
}
