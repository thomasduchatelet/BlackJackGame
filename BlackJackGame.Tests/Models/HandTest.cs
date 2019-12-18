﻿using BlackJackGame.Models;
using Xunit;

namespace BlackJackGame.Tests.Models
{

    public class HandTest
    {
        private Hand _aHand;

        public HandTest()
        {
            _aHand = new Hand();
        }

        [Fact]
        public void NewHand_HasNoCards()
        {
            Assert.Equal(0, _aHand.NrOfCards);
        }

        [Fact(Skip="Not yet implemented")]
        public void AddCard_EmptyHand_ResultsInHandWithOneCard()
        {

        }

        [Fact(Skip = "Not yet implemented")]
        public void AddCard_AHandWithCards_AddsACard()
        {
        }

        [Fact]
        public void TurnAllCardsFaceUp_TurnsAllCardsFaceUp()
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Ace);
            card.TurnCard();
            _aHand.AddCard(card);
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _aHand.TurnAllCardsFaceUp();
            foreach (BlackJackCard c in _aHand.Cards)
                Assert.True(c.FaceUp);
        }

        [Fact(Skip = "Not yet implemented")]
        public void Value_EmptyHand_IsZero()
        {
        }

        [Fact(Skip = "Not yet implemented")]
        public void Value_HandWith6and5_Is11()
        {
         }

        [Fact(Skip = "Not yet implemented")]
        public void Value_HandWith5AndKing_Is15()
        {
        }

        [Fact(Skip = "Not yet implemented")]
        public void Value_HandWithCardsFacingDown_DoesNotAddValuesOfCardsFacingDown()
        {
        }

        [Fact(Skip = "Not yet implemented")]
        public void Value_HandWithAceAndNotExceeding21_TakesAceAs11()
        {
        }

        [Fact(Skip = "Not yet implemented")]
        public void ValueHandWithAceAndExceeding21_TakesAceAs1()
        {
        }

        [Fact]
        public void Value_HandWithAceFaceDown_DoesNotCountAce()
        {
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _aHand.TurnAllCardsFaceUp();
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Ace));
            Assert.Equal(4, _aHand.Value);
        }
    }
}
