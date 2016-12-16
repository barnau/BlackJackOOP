using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace BlackJackTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardToString()
        {
            // Arrange
            Card card = new Card(0, 0);
            
            string expected = "2 of Spades";

            //Act
            var actual = card.CardToString();
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
