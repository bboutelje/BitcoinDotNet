using System;
namespace BitcoinDotNet.Policy
{
    public enum FeeEstimateMode
    {
        UNSET,        //! Use default settings based on other criteria
        ECONOMICAL,   //! Force estimateSmartFee to use non-conservative estimates
        CONSERVATIVE, //! Force estimateSmartFee to use conservative estimates
    }
}
