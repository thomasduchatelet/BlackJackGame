﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class BlackJackCard : Card
    {
        #region Properties
        public bool FaceUp { get; set; }
        public int Value 
        { 
            get { return FaceUp ? Math.Min(10, (int)FaceValue) : 0; }
        }
        #endregion

        #region Constructors
        public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit,faceValue)
        {
            FaceUp = false;
        }
        #endregion

        #region Methods
        public void TurnCard()
        {
            FaceUp = !FaceUp;
        }
        #endregion
    }
}
