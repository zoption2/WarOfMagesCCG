using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame
{
    [CreateAssetMenu(fileName = "GameResources", menuName = "ScriptableObjects/GameResources")]
    public class GameResources : ScriptableObject
    {
        [SerializeField] private GameObject cardPrefab;
        public GameObject CardPrefab => cardPrefab;

        [SerializeField] private Data.CardsModels cardsModelsPrefab;
        public Data.CardsModels CardsModelsPrefab => cardsModelsPrefab;
    }
}

