using NeverMindEver.Enemy.Data;
using NeverMindEver.Enemy.Logic;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy.Systems {
    public class EnemySpawner : MonoBehaviour{
        [Inject] private EnemyFactory _enemyFactory;
        [SerializeField] private EnemyBaseData _data;

        [SerializeField] private GameObject _prefab;


        private void Start() {
            SpawnEnemy(transform.position,_data,_prefab);
        }

        public void SpawnEnemy(Vector3 position,EnemyBaseData data,GameObject prefab) {
            EnemyComponent enemy = _enemyFactory.CreateEnemy(position, data,prefab);
        }
    }
}
