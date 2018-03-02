using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using BigMath;
using BitcoinDotNet.Primitives;

namespace BitcoinDotNet
{
    public class HashWriter
    {
        Hash256 ctx;

        int nType;
        int nVersion;

        public HashWriter(int nType, int nVersion)
        {
            this.nType = nType;
            this.nVersion = nVersion;
        }

        protected HashWriter()
        {
        }


        public byte[] GetHash()
        {
            SHA256 mySHA256 = SHA256Managed.Create();

            //mySHA256.
            //return mySHA256.Hash(this);

            return null;
        }

        internal void Write(ISerializable obj)
        {
            obj.Serialize(this);
        }

        public void Write(List<ISerializable> list)
        {

        }

        internal int GetVersion()
        {
            return nVersion;
        }

        internal void Write(int version)
        {
            throw new NotImplementedException();
        }

        internal void Write(List<TransactionIn> transactionsIn)
        {
            throw new NotImplementedException();
        }

        internal void Write(List<TransactionOut> transactionsOut)
        {
            throw new NotImplementedException();
        }
    }
}
