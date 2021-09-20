using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheGame.Card;
using TheGame.Data;

namespace TheGame
{
    public class ModelHolder
    {
        private CardsModels cardsModels;

        public CardsModels CardsModels
        {
            get
            {
                if (cardsModels == null)
                {
                    cardsModels = MonoCreator.Create<CardsModels>(Application.Instance.Resources.CardsModelsPrefab);
                }
                return cardsModels;
            }
        }
    }
}

