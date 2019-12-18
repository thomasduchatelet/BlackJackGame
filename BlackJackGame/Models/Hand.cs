using System;
using System.Collections.Generic;

namespace BlackJackGame.Models
{
    public class Hand
    {
        #region Fields
        private IList<BlackJackCard> _cards;
        #endregion

        #region Properties
        public IEnumerable<BlackJackCard> Cards { get; }
        public int NrOfCards { get; }
        public int Value { get; }
        #endregion

        #region Methods

        private int CalculateValue()
        {
            throw new NotImplementedException();
        }
        public void AddCard(BlackJackCard blackJackCard)
        {
            throw new NotImplementedException();
        }

        public void TurnAllCardsFaceUp()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}