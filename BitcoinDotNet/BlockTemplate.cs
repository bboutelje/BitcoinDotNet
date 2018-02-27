using System;
using System.Collections.Generic;
using BitcoinDotNet.Primitives;

namespace BitcoinDotNet
{
    public struct BlockTemplate
    {
        Block block;
        List<long> transactionFees;
        List<long> transactionSigOpsCost;
        string vchCoinbaseCommitment;
    }
}

