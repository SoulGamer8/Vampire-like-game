using System;
using NeverMindEver.Shared;
using UnityEngine;
using Zenject;

namespace NeverMindEver.Enemy {
    public class EnemyMediator : IInitializable, IDisposable {
        private readonly EnemyModel _enemy;
        private readonly HealthModel _health;

        public EnemyMediator(EnemyModel enemy, HealthModel health)
        {
            _enemy = enemy;
            _health = health;
        }

        public void Initialize()
        {
            _health.OnDeath += HandleDeath;
        }
        
        private void HandleDeath() {
            //TODO: Spawn coin, return enemy to pool
        }
        
        public void Dispose()
        {
            _health.OnDeath -= HandleDeath;
        }
    }
}
