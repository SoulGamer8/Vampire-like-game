using System;
using NeverMindEver.Shared;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy {
    public class EnemyMediator : IInitializable, IDisposable {
        private readonly EnemyComponent _enemy;

        public EnemyMediator(EnemyComponent enemy) {
            _enemy = enemy;
        }
        
        public void Initialize() {
            _enemy.HealthModel.OnDeath += HandleDeath;
        }
        
        private void HandleDeath() {
            Debug.Log("Death in mediator");
            Dispose();
        }

        public void Dispose() {
            _enemy.HealthModel.OnDeath -= HandleDeath;
        }

    }
}
