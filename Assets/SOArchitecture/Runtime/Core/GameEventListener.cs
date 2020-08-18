using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
#pragma warning disable 649

namespace SOArchitecture
{
    [Serializable]
    public abstract class GameEventListener<T> : MonoBehaviour
    {
        [SerializeField] private GameEvent<T> _event;

        public UnityEvent<T> OnRaised;

        private void OnEnable()
        {
            _event.Register(this);
        }

        private void OnDisable()
        {
            _event.Deregister(this);
        }

        public void Raise(T value)
        {
            OnRaised.Invoke(value);
        }
    }
}