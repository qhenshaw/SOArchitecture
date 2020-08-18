using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 649

namespace SOArchitecture
{
    public abstract class GameVariable<T> : ScriptableObject
    {
        [SerializeField] private T _value;

        public T Value
        {
            get => _value;
            set => _value = value;
        }
    }
}