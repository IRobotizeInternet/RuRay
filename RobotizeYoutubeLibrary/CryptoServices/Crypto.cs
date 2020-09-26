using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeYoutubeLibrary.CryptoServices
{
    public abstract class Crypto
    {
        public abstract string EncryptValue { get; }

        public abstract string DecryptValue { get; }
    }
}
