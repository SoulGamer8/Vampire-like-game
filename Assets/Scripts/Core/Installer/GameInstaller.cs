using NeverMindEver.Enemy;
using NeverMindEver.Enemy.Systems;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Installer {
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
