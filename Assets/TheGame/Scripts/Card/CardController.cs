using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame.Card
{
    public class CardController : MonoBehaviour
    {
        private CardView view;
        private CardModel model;

        public int UniqueID { get; private set; }

        public void InitializeController(CardModel model, int uniqueID)
        {
            this.model = model;
            this.UniqueID = uniqueID;
            view = GetComponent<CardView>();
        }
    }
}

