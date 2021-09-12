using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame
{
    public class Application : Singleton<Application>
    {
        public ModelHolder ModelHolder { get; private set; }
        public ResourcesHolder ResourcesHolder { get; private set; }
    }
}

