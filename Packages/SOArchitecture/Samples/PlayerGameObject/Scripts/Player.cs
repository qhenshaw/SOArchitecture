using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 649

namespace SOArchitecture
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private GameObjectEvent _spawnedEvent;

        private void Start()
        {
            _spawnedEvent.Raise(gameObject);
        }
    }
}