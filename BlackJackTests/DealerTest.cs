using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace BlackJackTests
{
    [TestClass]
    public class DealerTest
    {
        [TestMethod]
        public void DealerHasDeckTest()
        {
            // Arrange
            int expected = 52;
            Dealer dealer = new Dealer();
            //Act
            var actual = dealer.Deck.Count;
            // Assert
            Assert.AreEqual(actual, expected);

        }
    }
}
