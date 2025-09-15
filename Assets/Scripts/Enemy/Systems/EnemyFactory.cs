using NeverMindEver.Enemy.Data;
using NeverMindEver.Enemy.Logic;
using NeverMindEver.Shared;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy.Systems{
    public class EnemyFactory : IInitializable {
        private readonly DiContainer _container;
        private readonly Transform _playerTransform;
        private readonly GameObject _enemyPrefabs;
    
        public EnemyFactory(
            DiContainer container,
            [Inject(Id = "Player")] Transform playerTransform) {
        
            _container = container;
            _playerTransform = playerTransform;
        }
    
        public void Initialize() {
            // Ініціалізація якщо потрібно
        }
    
        public EnemyComponent CreateEnemy(Vector3 spawnPosition, EnemyBaseData enemyData,GameObject prefab) {
            // Створюємо GameObject
            GameObject enemyPrefab = prefab;
            GameObject enemyObject = Object.Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        
            // Отримуємо компонент
            EnemyComponent enemyComponent = enemyObject.GetComponent<EnemyComponent>();
        
            // Створюємо HealthModel
            HealthModel healthModel = new HealthModel(enemyData.health);
            EnemyModel enemyModel = new EnemyModel(enemyData.moveSpeed, enemyData.reward);
            // Ініціалізуємо ворога
            enemyComponent.Initialize(enemyModel, healthModel, _playerTransform);
        
            // Створюємо і налаштовуємо медіатор через DI
            EnemyMediator mediator = _container.Instantiate<EnemyMediator>(
                new object[] { enemyComponent }
            );
        
            mediator.Initialize();
        
            // Зберігаємо медіатор в компоненті для подальшого використання
            enemyObject.AddComponent<MediatorHolder>().SetMediator(mediator);
        
            return enemyComponent;
        }

    }
}
