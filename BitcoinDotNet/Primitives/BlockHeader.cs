using System;
using System.Collections.Generic;
using BigMath;
using BigMath.Utils;

namespace BitcoinDotNet.Primitives
{
    /** Nodes collect new transactions into a block, hash them into a hash tree,
     * and scan through nonce values to make the block's hash satisfy proof-of-work
     * requirements.  When they solve the proof-of-work, they broadcast the block
     * to everyone and the block is added to the block chain.  The first transaction
     * in the block is a special one that creates a new coin owned by the creator
     * of the block.
     */

    public class BlockHeader
    {
        public Int32 nVersion;
        public Int256 hashPrevBlock;
        public Int256 hashMerkleRoot;
        public UInt32 nTime;
        public UInt32 nBits;
        public UInt32 nNonce;

        protected List<Transaction> Transactions { get; set; }

        public BlockHeader()
        {
        }

        public long GetHash()
        {
            HashWriter ss = new HashWriter(nType, nVersion);
            ss << obj;
            return ss.GetHash();


            return SerializeHash(this);
        }
    }
}
