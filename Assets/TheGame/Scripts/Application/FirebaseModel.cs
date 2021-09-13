using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;

namespace TheGame
{
    public class FirebaseModel : AbstractModel
    {
        private static DatabaseReference database;
        protected override void Initialize()
        {
            base.Initialize();
            database = FirebaseDatabase.DefaultInstance.RootReference;
        }
    }
}

