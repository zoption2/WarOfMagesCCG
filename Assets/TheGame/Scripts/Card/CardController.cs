using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame.Card
{
    public class CardController
    {
        private CardView view;
        private CardModel model;

        public CardController(CardModel model, CardView view)
        {
            this.model = model;
            this.view = view;
        }
    }
}

