using NeverMindEver.Shared;
using UnityEngine;

namespace NeverMindEver.Enemy
{
    public class EnemyComponent : MonoBehaviour, IDamagable {
        private EnemyModel _enemyModel;
        private HealthModel _healthModel;
        
        
        public void TakeDamage(int damage)
        {
            throw new System.NotImplementedException();
        }
    }
}
