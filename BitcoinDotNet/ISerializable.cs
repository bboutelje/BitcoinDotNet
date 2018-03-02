using System.IO;

namespace BitcoinDotNet
{
    public interface ISerializable
    {
        void Serialize(HashWriter os);
    }
}