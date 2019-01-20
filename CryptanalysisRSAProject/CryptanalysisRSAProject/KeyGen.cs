using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptanalysisRSAProject
{
    class KeyGen
    {
        Random rnd = new Random();
        private long prime1, prime2;
        private long n;
        private int e = 3;

        public KeyGen (long prime1, long prime2)
        {
            this.prime1 = prime1;
            this.prime2 = prime2;
            this.n = prime1 * prime2;
        }

        public PublicKey getPublicKey ()
        {
            PublicKey pubKey = new PublicKey(e,n);
            return pubKey;
        }

        public long getPrivateKey()
        {
            long fiOfN = (prime1 - 1) * (prime2 - 1);
            int k = rnd.Next(1, 1000);
            long d = (k * fiOfN + 1) / e;
            return d;
        }       


    }

    public struct PublicKey
    {
        public int e;
        public long n;

        public PublicKey (int e, long n)
        {
            this.e = e;
            this.n = n;
        }

    }

}
