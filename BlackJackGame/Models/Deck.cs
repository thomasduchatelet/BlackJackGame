using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class Deck
    {
        #region Fields
        private IList<BlackJackCard> _cards;
        private Random _random;
        #endregion

        #region Methods
        public BlackJackCard Draw()
        {
            throw new NotImplementedException();
        }

        private void Shuffle()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
