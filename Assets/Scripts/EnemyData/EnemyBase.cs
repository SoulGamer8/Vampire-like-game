using UnityEngine;

namespace NeverMindEver.EnemyData
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/Enemy")]
    public class EnemyDataBase : ScriptableObject {
        public int health;
        public int damage;
        public float moveSpeed;
        public int reward;
        
    }
}
