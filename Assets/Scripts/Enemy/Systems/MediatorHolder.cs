using UnityEngine;

namespace NeverMindEver.Enemy.Systems
{
    public class MediatorHolder : MonoBehaviour
    {
        private EnemyMediator _mediator;
    
        public void SetMediator(EnemyMediator mediator) {
            _mediator = mediator;
        }
    
        private void OnDestroy() {
            _mediator?.Dispose();
        }
    }
}
