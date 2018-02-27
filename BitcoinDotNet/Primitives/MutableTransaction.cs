using System;
using System.Collections.Generic;

namespace BitcoinDotNet.Primitives
{
    public class MutableTransaction
    {
        List<TransactionIn> vin;
        List<TransactionOut> vout;
        int nVersion;
        uint nLockTime;
        public MutableTransaction()
        {
        }
    }
}
