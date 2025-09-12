using Zenject;
using NeverMindEver.EnemyData;
using NeverMindEver.Shared;
using UnityEngine;

namespace NeverMindEver.Enemy {
    
    [CreateAssetMenu(menuName = "Installers/EnemyInstaller")]
    public class EnemyInstaller : ScriptableObjectInstaller<EnemyInstaller> {
        public EnemyDataBase data;

        public override void InstallBindings() {
            Container.Bind<HealthModel>().AsSingle().WithArguments(data.health);
            Container.Bind<EnemyModel>().AsSingle().WithArguments(data.moveSpeed,data.reward);
            Container.BindInterfacesAndSelfTo<EnemyMediator>().AsSingle().NonLazy();
        }
    }
}
