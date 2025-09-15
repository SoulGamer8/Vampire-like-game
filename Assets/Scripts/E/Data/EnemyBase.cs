using UnityEngine;

namespace NeverMindEver.Enemy.Data
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/Enemy")]
    public class EnemyBaseData : ScriptableObject {
        public int health;
        public int damage;
        public float moveSpeed;
        public int reward;
        
    }
}
