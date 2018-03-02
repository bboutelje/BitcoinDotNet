using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using BigMath;

namespace BitcoinDotNet.Primitives
{
    public class Transaction : ISerializable
    {
        private Int256 hash;

        // Default transaction version.
        const int CURRENT_VERSION = 2;

        // Changing the default transaction version requires a two step process: first
        // adapting relay policy by bumping MAX_STANDARD_VERSION, and then later date
        // bumping the default CURRENT_VERSION at which point both CURRENT_VERSION and
        // MAX_STANDARD_VERSION will be equal.
        const int MAX_STANDARD_VERSION = 2;

        // The local variables are made const to prevent unintended modification
        // without updating the cached hash value. However, CTransaction is not
        // actually immutable; deserialization and assignment are implemented,
        // and bypass the constness. This is safe, as they update the entire
        // structure, including the hash.
        public List<TransactionIn> TransactionsIn { get; set; }
        public List<TransactionOut> TransactionsOut { get; set; }
        public int Version { get; set; }
        int nLockTime;

        const int SERIALIZE_TRANSACTION_NO_WITNESS = 0x40000000;

        Int256 ComputeHash()
        {
            return 0;
        }
        public Transaction()
        {
        }

        public override string ToString()
        {
            string str;
            str = $"Transaction(hash={GetHash().ToString().Substring(0, 10)}, ver={Version}, vin.size={TransactionsIn.Count}, " +
                $"vout.size={TransactionsOut.Count}, nLockTime={nLockTime})\n";
            foreach (var transactionIn in TransactionsIn)
            {
                str += "    " + transactionIn.ToString() + "\n";
            }
            foreach (var transactionIn in TransactionsIn)
            {
                str += "    " + transactionIn.ScriptWitness.ToString() + "\n";
            }
            foreach (var transactionOut in TransactionsOut)
                str += "    " + TransactionsOut.ToString() + "\n";
            return str;
        }

        private byte[] GetHash()
        {
            var mySHA256 = SHA256.Create();

            byte[] byteArray = Encoding.UTF8.GetBytes(ToString());
            MemoryStream stream = new MemoryStream(byteArray);

            mySHA256.ComputeHash(stream);
            return mySHA256.Hash;
        }

        public void SerializeTransaction(Transaction transaction, HashWriter s)
        {
            bool fAllowWitness = (s.GetVersion() & SERIALIZE_TRANSACTION_NO_WITNESS) == 0;

            s.Write(transaction.Version);
            

            s.Write(transaction.TransactionsIn);
            s.Write(transaction.TransactionsOut);
            if (flags & 1 != 0)
            {
                for (size_t i = 0; i < tx.vin.size(); i++)
                {
                    s << tx.vin[i].scriptWitness.stack;
                }
            }
            s << tx.nLockTime;
        }

        private bool HasWitness { get; set; }

        public void Serialize(HashWriter os)
        {
            
        }
    }
}
