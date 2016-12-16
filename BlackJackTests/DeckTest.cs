using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace BlackJackTests
{
    [TestClass]
    public class DeckTest
    {
        [TestMethod]
        public void NumberOFCardTest()
        {
            // Arrange
            Deck deck = new Deck();
            int expected = 52;
            // Act
            var actual = deck.FullDeck.Count;
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void DealTest()
        {
            //Arrange
            var expectedNumber = 51;
            var expectedCard = new Card(0, 1);

            //Act
            Deck deck = new Deck();
            var actualCard = deck.Deal();
            var actualNumber = deck.FullDeck.Count;
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(actualCard.GetType(), typeof(Deck));
            Assert.AreEqual(deck.DeckCount, expectedNumber);
        }
    }
}
