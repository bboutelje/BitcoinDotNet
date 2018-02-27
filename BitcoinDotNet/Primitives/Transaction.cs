using System;
using System.Collections.Generic;
using BigMath;

namespace BitcoinDotNet.Primitives
{
    public class Transaction
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
        public List<TransactionIn> transactionsIn;
        public List<TransactionOut> transactionsOut;
        int nVersion;
        int nLockTime;


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
            str = $"Transaction(hash={GetHash().ToString().Substring(0, 10)}, ver={nVersion}, vin.size={transactionsIn.Count}, " +
                $"vout.size={transactionsOut.Count}, nLockTime={nLockTime})\n";
            foreach (var transactionIn in transactionsIn)
            {
                str += "    " + transactionIn.ToString() + "\n";
            }
            foreach (var transactionIn in transactionsIn)
            {
                str += "    " + transactionIn.ScriptWitness.ToString() + "\n";
            }
            foreach (var transactionOut in transactionsOut)
                str += "    " + transactionsOut.ToString() + "\n";
            return str;
        }

        private object GetHash()
        {
            throw new NotImplementedException();
        }
    }
}
