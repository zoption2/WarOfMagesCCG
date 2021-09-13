using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame
{
    public class Application : Singleton<Application>
    {
        [SerializeField] private ResourcesHolder resources;
        public ModelHolder AllModels { get; private set; }
        public ResourcesHolder Resources => resources;

        public void Initialize()
        {
            AllModels = new ModelHolder();
        }
    }
}

