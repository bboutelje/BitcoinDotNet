using System;
namespace BitcoinDotNet.Wallet
{
    public class DbEnvironment
    {
        bool fDbEnvInit;
        bool fMockDb;
        // Don't change into fs::path, as that can result in
        // shutdown problems/crashes caused by a static initialized internal pointer.
        string strPath;

        void EnvShutdown()
        {
            
        }
        public DbEnvironment()
        {
        }
    }
}
