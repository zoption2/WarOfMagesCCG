using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame
{
    public class MonoCreator : MonoBehaviour
    {
        public static T Create<T> (T objectToCreate) where T : Object
        {
            var instance = Instantiate(objectToCreate);
            return instance;
        }
    }
}

