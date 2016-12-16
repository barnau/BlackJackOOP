using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace BlackJackTests
{
    [TestClass]
    public class BasePlayerTest
    {
        [TestMethod]
        public void ReceiveCardTest()
        {
            // Arrange
            BasePlayer player = new BasePlayer();
            Card card = new Card(0, 0);
            var expectedHandValue = 2;
            var expectedNumOfCards = 1;

            // Act
            player.ReceiveCard(card);
            var actualHandValue = player.HandValue;
            var actualNumOfCards = player.NumOfCards;
            // Assert
            Assert.AreEqual(expectedHandValue, actualHandValue);
            Assert.AreEqual(expectedNumOfCards, actualNumOfCards);
        }
    }
}
