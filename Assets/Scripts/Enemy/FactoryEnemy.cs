using NeverMindEver.EnemyData;
using NeverMindEver.Shared;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy{
    public class FactoryEnemy :  IFactory<EnemyDataBase, EnemyMediator> {
        private readonly DiContainer _container;

        public FactoryEnemy(DiContainer container)
        {
            _container = container;
        }

        public EnemyMediator Create(EnemyDataBase enemyData)
        {
            // Створюємо тимчасовий sub-container для цього ворога
            var subContainer = _container.CreateSubContainer();
        
            // Біндимо дані конкретного ворога
            subContainer.Bind<HealthModel>().AsSingle().WithArguments(enemyData.health);
            subContainer.Bind<EnemyModel>().AsSingle().WithArguments(enemyData.moveSpeed, enemyData.reward);
        
            // Створюємо EnemyMediator через sub-container
            return subContainer.Instantiate<EnemyMediator>();
        }

    }
}
