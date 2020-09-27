namespace RobotizeFacebookLibrary.CryptoServices
{
    public abstract class Crypto
    {
        public abstract string EncryptValue { get; }

        public abstract string DecryptValue { get; }
    }
}
