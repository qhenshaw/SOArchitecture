using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 649

namespace SOArchitecture
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private GameObjectVariable _playerGO;

        private void Update()
        {
            if (_playerGO?.Value)
            {
                Debug.DrawLine(transform.position, _playerGO.Value.transform.position, Color.red);
            }
        }
    }
}