using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture
{
    public class GameEvent<T> : ScriptableObject
    {
        private List<GameEventListener<T>> _listeners = new List<GameEventListener<T>>();

        public UnityEvent<T> OnRaised;
    
        public void Register(GameEventListener<T> listener)
        {
            if (_listeners.Contains(listener)) return;
            _listeners.Add(listener);
        }

        public void Deregister(GameEventListener<T> listener)
        {
            if (!_listeners.Contains(listener)) return;
            _listeners.Remove(listener);
        }

        public void Raise(T value)
        {
            for (int i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].Raise(value);
            }
        
            OnRaised.Invoke(value);
        }
    }
}