using System;

namespace NeverMindEver.Shared{
    public class HealthModel{
        public int Current { get; private set; }
        public int Max { get; private set; }
        
        public event Action OnDeath;
        
        public HealthModel(int maxHp){
            Max = maxHp;
            Current = maxHp;
        }
        
        public void TakeDamage(int value){
            Current = Math.Max(0, Current - value);
            if (Current == 0) OnDeath?.Invoke();
        }

        public void Heal(int value) {
            Current = Math.Min(Max, Current + value);
        }
    }
}
