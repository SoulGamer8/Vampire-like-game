using System;
using NeverMindEver.Enemy.Logic;
using NeverMindEver.Shared;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy.Systems {
    public class EnemyMediator : IInitializable, IDisposable {
        private readonly EnemyComponent _enemy;

        public EnemyMediator(EnemyComponent enemy) {
            _enemy = enemy;
        }
        
        public void Initialize() {
            _enemy.HealthModel.OnDeath += HandleDeath;
        }
        
        private void HandleDeath() {
            //TODO: Retrun to pool, spawn coin
            Debug.Log("Death in mediator");
            Dispose();
        }

        public void Dispose() {
            _enemy.HealthModel.OnDeath -= HandleDeath;
        }

    }
}
