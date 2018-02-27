using System;
namespace BitcoinDotNet.Script
{
    public enum BitcoinConsensusError
    {
        OK = 0,
        TX_INDEX,
        TX_SIZE_MISMATCH,
        TX_DESERIALIZE,
        AMOUNT_REQUIRED,
        INVALID_FLAGS,
    }
}
