using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class BlackJack
    {
        #region Fields
        private Deck _deck;
        public const bool FaceDown = false;
        public const bool FaceUp = true;
        #endregion

        #region Properties
        public GameState GameState { get; set; }
        public Hand DealerHand { get; set; }
        public Hand PlayerHand { get; set; }
        #endregion

        #region Constructors
        public BlackJack() { }
        
        public BlackJack(Deck deck)
        {
            this._deck = deck;
        }
        #endregion

        #region Methods
        private void AddCardToHand(Hand hand, bool faceUp)
        {
            throw new NotImplementedException();
        }

        private void AdjustGameState(GameState? gameState = null)
        {
            throw new NotImplementedException();
        }

        private void Deal() 
        {
            throw new NotImplementedException();
        }

        private void LetDealerFinalize()
        {
            throw new NotImplementedException();
        }

        public string GameSummary()
        {
            throw new NotImplementedException();
        }

        public void GivePlayerAnotherCard()
        {
            throw new NotImplementedException();
        }

        public void PassToDealer()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
