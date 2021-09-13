using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TheGame.Card
{
    public class CardView : MonoBehaviour, ICardView
    {
        [SerializeField] private Text cardName;
        [SerializeField] private Image element;
        [SerializeField] private TextMeshProUGUI cardType;
        [SerializeField] private TextMeshProUGUI defenceValue;
        [SerializeField] private Text description;
        [SerializeField] private GameObject magicCostHolder;
        [SerializeField] private CountVisual magicCount;

        private CardController controller;
        private CardModel model;

        public void InitializeView(CardModel model, CardController controller)
        {
            this.model = model;
            this.controller = controller;

            model.OnNameChanged += SetCardName;
        }

        public void SetCardName(string name)
        {
            cardName.text = name;
        }

        public void SetCardType(string type)
        {
            cardType.SetText(type);
        }

        public void SetElement(Sprite elementSprite)
        {
            element.sprite = elementSprite;
        }

        public void SetDefenceValue(int value)
        {
            defenceValue.SetText(value.ToString());
        }

        public void SetDescription(string text)
        {
            description.text = text;
        }

        public void ActivateMagicCostHolder(bool isActive)
        {
            magicCostHolder.SetActive(isActive);
        }

        public void SetMagicCostValue(int value)
        {
            magicCount.ShowAllOf(value);
        }
    }
}

