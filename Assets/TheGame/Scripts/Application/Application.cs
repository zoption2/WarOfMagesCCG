using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame
{
    public class Application : Singleton<Application>
    {
        [SerializeField] private GameResources gameResources;
        [SerializeField] private CardDataHolder cardDataHolder;

        private ModelHolder modelHolder;
        public ModelHolder ModelHolder
        {
            get
            { 
                if (modelHolder == null)
                {
                    modelHolder = new ModelHolder();
                }
                return modelHolder;
            }
        }


        public GameResources Resources => gameResources;
        public CardDataHolder CardDataHolder => cardDataHolder;


        public void Initialize()
        {
            
        }
    }
}

