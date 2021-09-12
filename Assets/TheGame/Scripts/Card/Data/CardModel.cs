using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TheGame.Card
{
    public class CardModel
    {
        private CardData data;
        private CardController controller;

        public event Action<string> OnNameChanged;

        public CardModel(CardController controller, CardData data)
        {
            this.controller = controller;
            this.data = data;
        }

        public void Initialize()
        {
            DoNameChange(data.CardName);
        }

        private void DoNameChange(string name)
        {
            OnNameChanged?.Invoke(name);
        }
    }
}

