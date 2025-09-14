using NeverMindEver.EnemyData;
using NeverMindEver.Shared;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy{
    public class EnemyFactory{
        private readonly DiContainer _container;
        private readonly EnemyComponent _prefab;

        public EnemyFactory(DiContainer container, EnemyComponent prefab) {
            _container = container;
            _prefab = prefab;
        }

        public EnemyComponent Create(Vector3 pos, EnemyDataBase data) {
            // беремо з пулу або інстанціюємо
            var enemy = GameObject.Instantiate(_prefab, pos, Quaternion.identity);
            var enemyModel = new EnemyModel(data.moveSpeed,data.reward);
            var health = new HealthModel(data.health);
            enemy.Initialize(enemyModel, health);

            // створюємо Mediator через Zenject
            _container.Instantiate<EnemyMediator>(
                new object[] { enemy });

            return enemy;
        }

    }
}
