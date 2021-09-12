using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System;

namespace TheGame.Card
{
    [CreateAssetMenu(fileName = "NewCardData", menuName = "Card/CardData")]
    public class CardData : ScriptableObject
    {
        [SerializeField] private int id;
        [SerializeField] private string cardName = "";
        [SerializeField] private AssetReferenceSprite blackWhiteImage;
        [SerializeField] private AssetReferenceSprite colorImage;
        [SerializeField] private int defenceValue;
        [SerializeField] private Element element;
        [SerializeField] private CardType type = CardType.Guardian;
        [SerializeField] private Element[] buyCost;
        private int maxCost = 7;

        public int ID => id;
        public string CardName { get => cardName; }
        public AssetReferenceSprite BlackWhiteImage { get => blackWhiteImage; }
        public AssetReferenceSprite ColorImage { get => colorImage; }
        public int DefenceValue { get => defenceValue; set => defenceValue = value; }
        public Element Element { get => element; set => element = value; }
        public CardType Type { get => type; set => type = value; }
        public Element[] BuyCost { get => buyCost; set => buyCost = value; }

        void OnValidate()
        {
            if (buyCost.Length > maxCost)
            {
                Debug.LogWarning("Maximum size of buy cost : " + maxCost);
                Array.Resize(ref buyCost, maxCost);
            }
        }
    }
}

