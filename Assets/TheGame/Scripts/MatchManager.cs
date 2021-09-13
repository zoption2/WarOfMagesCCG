using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame.Match
{
    public class MatchManager : Singleton<MatchManager>
    {
        [SerializeField] private ResourcesHolder resources;

        private LoadedDeck loadedDeck;
        public LoadedDeck LoadedDeck
        {
            get => loadedDeck == null ? loadedDeck = Instantiate(resources.GetItem(Constants.Match.loadedDeck) as LoadedDeck) : loadedDeck;
        }
    }
}

