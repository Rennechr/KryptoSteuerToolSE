using KryptoSteuernTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKryptoSteuernTool
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAssetAmountChange()
        {
            Asset asset = new Asset("BTC", 100);
            asset.changeAmount(30);
            Assert.AreEqual(asset.amount, 130);
            Assert.AreEqual(asset.kuerzel, "BTC");
        }
        [TestMethod]
        public void TestWalletReciveAsset()
        {
            Wallet wallet = new Wallet("Binance");
            wallet.reciveAsset("BTC", (decimal)100.22);

            Assert.AreEqual(wallet.assets[0].kuerzel, "BTC");
            Assert.AreEqual(wallet.assets[0].amount, (decimal)100.22);
        }

        [TestMethod]
        public void TestUserCreateWallet()
        {
            User user = new User();

            user.addWallet("Binance");

            Assert.AreEqual(user.wallets.Count, 1);
            Assert.AreEqual(user.wallets[0].name, "Binance");
        }

        [TestMethod]
        public void TestUserDeposit()
        {
            User user = new User();
            user.addWallet("Binance");
            user.deposit("Binance", "BTC", (decimal)0.1);

            Assert.AreEqual(user.wallets.Count, 1);
            Assert.AreEqual(user.wallets[0].assets.Count, 1);
            Assert.AreEqual(user.wallets[0].assets[0].kuerzel, "BTC");
            Assert.AreEqual(user.wallets[0].assets[0].amount, (decimal)0.1);
        }

        [TestMethod]
        public void TestUserWithdrawl()
        {
            User user = new User();
            user.addWallet("Binance");
            user.wallets[0].reciveAsset("BTC", (decimal)0.1);
            user.withdrawl("Binance", "BTC", (decimal)0.1);

            Assert.AreEqual(user.wallets.Count, 1);
            Assert.AreEqual(user.wallets[0].assets.Count, 1);
            Assert.AreEqual(user.wallets[0].assets[0].kuerzel, "BTC");
            Assert.AreEqual(user.wallets[0].assets[0].amount, (decimal)0);
        }
        [TestMethod]
        public void TestWalletAssetExist()
        {
            Wallet wallet = new Wallet();
            wallet.reciveAsset("BTC");

            Assert.AreEqual(wallet.assets.Count, 1);
            Assert.IsTrue(wallet.assetExists("BTC"));
            Assert.IsFalse(wallet.assetExists("DOGE"));
        }

    }
}