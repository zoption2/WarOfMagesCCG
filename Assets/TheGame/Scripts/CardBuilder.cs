using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheGame.Card;
using TheGame.Data;
using UnityEngine.AddressableAssets;

namespace TheGame
{
    public class CardBuilder : MonoBehaviour
    {
        public GameObject GetCard(int id)
        {
            GameObject newCard = Instantiate(Application.Instance.Resources.CardPrefab);
            var controller = newCard.GetComponent<CardController>();
            CardData data = Application.Instance.CardDataHolder.GetData(id);
            CardModel model = new CardModel(controller, data);
            model.Initialize();
            return newCard;
        }

    }
}

