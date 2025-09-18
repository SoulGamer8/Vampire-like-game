using UnityEngine;

namespace NeverMindEver.Player {
    public class PlayerMove:MonoBehaviour {
        [SerializeField] private float speed = 5f; // одиниці в секунду
        private Rigidbody2D _rb;
        private Vector2 _moveInput;

        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            // Щоб гравець не крутился при фізичних зіткненнях:
            _rb.freezeRotation = true;
        }

        void Update()
        {
            // Отримуємо ввід (WASD / стрілки) стандартними осями
            float x = Input.GetAxisRaw("Horizontal"); // -1,0,1
            float y = Input.GetAxisRaw("Vertical");
            _moveInput = new Vector2(x, y).normalized; // нормалізуємо, щоб не бігати швидше по діагоналі
        }

        void FixedUpdate()
        {
            _rb.linearVelocity = _moveInput * speed;
        }
    }
}
