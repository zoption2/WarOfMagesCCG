using UnityEngine;

namespace TheGame.Card
{
    public interface ICardView
    {
        public void SetCardName(string name);
        public void SetCardType(string type);
        public void SetDefenceValue(int value);
        public void SetDescription(string text);
        public void ActivateMagicCostHolder(bool isActive);
        public void SetMagicCostValue(int value);
    }
}

