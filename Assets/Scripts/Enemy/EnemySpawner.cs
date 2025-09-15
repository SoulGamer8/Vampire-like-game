using System;
using NeverMindEver.EnemyData;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy
{
    public class EnemySpawner : MonoBehaviour{
        [Inject] private EnemyFactory _enemyFactory;
        [SerializeField] private EnemyDataBase _data;

        [SerializeField] private GameObject _prefab;


        private void Start() {
            SpawnEnemy(transform.position,_data,_prefab);
        }

        public void SpawnEnemy(Vector3 position,EnemyDataBase data,GameObject prefab) {
            EnemyComponent enemy = _enemyFactory.CreateEnemy(position, data,prefab);
        }
    }
}
