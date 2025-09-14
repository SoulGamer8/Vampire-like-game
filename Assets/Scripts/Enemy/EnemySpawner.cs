using System;
using NeverMindEver.EnemyData;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy
{
    public class EnemySpawner : MonoBehaviour{
        [SerializeField] private GameObject _prefab;
        [SerializeField] private EnemyDataBase[] enemyTypes;
        private FactoryEnemy _enemyFactory;

        [Inject]
        public void Construct(FactoryEnemy enemyFactory)
        {
            _enemyFactory = enemyFactory;
        }

        public void SpawnEnemy(int enemyTypeIndex)
        {
            var enemyData = enemyTypes[enemyTypeIndex];
            var enemy = _enemyFactory.Create(enemyData);
            _prefab.AddComponent(EnemyComponent)
            Instantiate()
            // Налаштовуємо позицію, батьківський об'єкт і т.д.
        }

        private void Start()
        {
            SpawnEnemy(0);
        }
    }
}
