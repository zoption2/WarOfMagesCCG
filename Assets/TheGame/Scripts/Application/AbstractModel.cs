using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame
{
    public abstract class AbstractModel
    {
        protected Application App => Application.Instance;

        public AbstractModel()
        {

        }

        protected virtual void Initialize()
        {

        }

        protected virtual void CloseModel()
        {

        }
    }
}

