using System;
namespace BitcoinDotNet.Policy
{
    /**
     * Fee rate in satoshis per kilobyte: CAmount / kB
     */
    public class FeeRate
    {
        long nSatoshisPerK;
        public FeeRate()
        {
        }
    }
}
