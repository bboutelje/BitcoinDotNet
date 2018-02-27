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
            using (var s = new StreamWriter(""))
            {
                s.Write($"Block(hash={GetHash().ToString()}, ver=0x{nVersion}, hashPrevBlock={hashPrevBlock.ToString()}, hashMerkleRoot={hashMerkleRoot.ToString()}, nTime={nTime}, nBits={nBits}, nNonce={nNonce}, vtx={Transactions.Count})\n");

                foreach (var transaction in Transactions)
                {
                    s.Write($" {transaction.ToString()}" + Environment.NewLine);
                }

                return s.ToString();
            }
        }
    }
}
