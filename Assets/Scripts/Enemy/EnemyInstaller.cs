using Zenject;
using NeverMindEver.EnemyData;
using NeverMindEver.Shared;
using UnityEngine;

namespace NeverMindEver.Enemy {
    public class EnemyInstaller : MonoInstaller {
        [SerializeField] private EnemyComponent enemyPrefab;
        public override void InstallBindings() {

            // Фабрика з інжектом
            Container.Bind<EnemyFactory>().AsSingle()
                .WithArguments(enemyPrefab);
        }
    }
}
