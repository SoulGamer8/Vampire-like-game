using System;
using NeverMindEver.Shared;
using UnityEngine;

namespace NeverMindEver.Enemy {
    public class EnemyComponent : MonoBehaviour, IDamagable {
        public EnemyModel EnemyModel{ get; private set; }
        public HealthModel HealthModel{ get; private set; }
        
        private Transform _playerTransform;
        
        public void Initialize(EnemyModel enemyModel,HealthModel healthModel) {
            enemyModel = enemyModel;
            healthModel = healthModel;
            healthModel.OnDeath += Death;
        }

        private void Update() {
            MoveToPlayer();
        }
        
        private void MoveToPlayer() {
            transform.position = Vector2.MoveTowards(transform.position, _playerTransform.position,EnemyModel.CurrentSpeed * Time.deltaTime);
        }

        private void Death() {
            Debug.Log(gameObject.name + " is death");
        }
        
        public void TakeDamage(int damage) {
            HealthModel.TakeDamage(damage);
        }
    }
}
