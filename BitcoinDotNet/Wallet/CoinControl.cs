using System;
using BitcoinDotNet.Policy;

namespace BitcoinDotNet.Wallet
{
    public class CoinControl
    {
        TransactionDestination destChange;
        //! If false, allows unselected inputs, but requires all selected inputs be used
        bool fAllowOtherInputs;
        //! Includes watch only addresses which match the ISMINE_WATCH_SOLVABLE criteria
        bool fAllowWatchOnly;
        //! Override automatic min/max checks on fee, m_feerate must be set if true
        bool fOverrideFeeRate;
        //! Override the default payTxFee if set
        FeeRate m_feerate;
        //! Override the default confirmation target if set
        uint m_confirm_target;
        //! Signal BIP-125 replace by fee.
        bool signalRbf;
        //! Fee estimation mode to control arguments to estimateSmartFee
        FeeEstimateMode m_fee_mode;
        public CoinControl()
        {
        }
    }
}
