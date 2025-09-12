using System;
using NeverMindEver.Shared;
using UnityEngine;

namespace NeverMindEver.Enemy {
    public class EnemyComponent : MonoBehaviour, IDamagable {
        private EnemyModel _enemyModel;
        private HealthModel _healthModel;
        private Transform _playerTransform;
        public void Initialize(EnemyModel enemyModel,HealthModel healthModel) {
            _enemyModel = enemyModel;
            _healthModel = healthModel;
            _healthModel.OnDeath += Death;
        }

        private void Update() {
            MoveToPlayer();
        }
        
        private void MoveToPlayer() {
            transform.position = Vector2.MoveTowards(transform.position, _playerTransform.position,_enemyModel.CurrentSpeed * Time.deltaTime);
        }

        private void Death() {
            Debug.Log(gameObject.name + " is death");
        }
        
        public void TakeDamage(int damage) {
            _healthModel.TakeDamage(damage);
        }
    }
}
