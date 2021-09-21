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
        public int ID { get; private set;}

        public event Action<string> OnNameChanged;
        public event Action<CardType> OnCardTypeChanged;
        public event Action<int> OnDefenceValueChanged;
        public event Action<string> OnDescriptionChanged;
        public event Action<int> OnMagicCostValueChanged;
        public event Action<Element> OnElementChanged;

        public CardModel(CardController controller, CardData data)
        {
            this.controller = controller;
            this.data = data;
        }

        public void Initialize()
        {
            ID = GenerateID();
            Application.Instance.ModelHolder.CardsModels.Add(ID, this);
            controller.InitializeController(this, ID);
            DoNameChange(data.CardName);
        }

        private int GenerateID()
        {
            var id = UnityEngine.Random.Range(100000, 999999);
            string key = data.ID.ToString() + id.ToString();
            id = int.Parse(key);
            return id;
        }

        private void DoNameChange(string name)
        {
            OnNameChanged?.Invoke(name);
        }

        public void DoCardTypeChange(CardType type)
        {
            OnCardTypeChanged?.Invoke(type);
        }

        public void DoDefenceValueChange(int value)
        {
            OnDefenceValueChanged?.Invoke(value);
        }

        public void SetDescription(string text)
        {
            
        }

        public void ActivateMagicCostHolder(bool isActive)
        {
            
        }

        public void SetMagicCostValue(int value)
        {
            
        }

        public void DoElementChange(Element element)
        {

        }
    }
}

