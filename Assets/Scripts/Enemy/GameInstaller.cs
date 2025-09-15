using Zenject;
using NeverMindEver.EnemyData;
using NeverMindEver.Shared;
using UnityEngine;

namespace NeverMindEver.Enemy {
    public class GameInstaller : MonoInstaller {
        [SerializeField] private Transform _playerTransform;
    
        public override void InstallBindings() {
            Container.Bind<Transform>().WithId("Player").FromInstance(_playerTransform);
            Container.Bind<EnemyFactory>().AsSingle();
            Container.Bind<EnemyMediator>().AsTransient();
            
            Container.Bind<EnemySpawner>().FromComponentInHierarchy().AsSingle();
        }
    }
}
