using System;
namespace BitcoinDotNet.Primitives
{
    public class TransactionIn
    {
        public TransactionIn()
        {
        }
        public object ScriptWitness
        {
            get;
            set;
        }
    }
}
