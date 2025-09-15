using UnityEngine;

namespace NeverMindEver.Enemy.Logic {
    public class EnemyModel
    {
        public float BaseSpeed;
        public float CurrentSpeed { get;private set; }
        public int Reward { get;private set; }
        
        public EnemyModel(float speed,int reward){
            BaseSpeed = speed;
            CurrentSpeed = speed;
            Reward = reward;
        }
        
        public void ApplySlow(float factor) {
            CurrentSpeed = BaseSpeed * factor;
        }

        public void ResetSpeed() {
            CurrentSpeed = BaseSpeed;
        }
    }
}
