using System;
using BitcoinDotNet.Primitives;

namespace BitcoinDotNet
{
    public class Hash
    {
        public Hash()
        {
        }

        internal static object SerializeHash(Transaction transaction, int nType, int nVersion)
        {
            HashWriter ss = new HashWriter(nType, nVersion);
            ss.Write(transaction);


            return ss.GetHash();
        }
    }
}
