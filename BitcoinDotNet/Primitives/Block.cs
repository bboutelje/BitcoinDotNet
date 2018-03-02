using System;
using System.IO;

namespace BitcoinDotNet.Primitives
{
    public class Block : BlockHeader
    {
        public Block()
        {
        }
        public override string ToString()
        {
            string str = $"Block(hash={GetHash().ToString()}, ver=0x{nVersion}, hashPrevBlock={hashPrevBlock.ToString()}, hashMerkleRoot={hashMerkleRoot.ToString()}, nTime={nTime}, nBits={nBits}, nNonce={nNonce}, vtx={Transactions.Count})\n";

            foreach (var transaction in Transactions)
            {
                str += ($" {transaction.ToString()}" + Environment.NewLine);
            }

            return str;
            
        }
    }
}
