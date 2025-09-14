using System;
using NeverMindEver.EnemyData;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy
{
    public class EnemySpawner : MonoBehaviour{
        [Inject] private EnemyFactory _factory;
        [SerializeField] private EnemyDataBase _data;

        private void Start()
        {
            SpawnEnemy(transform.position);
        }

        public void SpawnEnemy(Vector3 pos) {
            _factory.Create(pos, _data);
        }
    }
}
