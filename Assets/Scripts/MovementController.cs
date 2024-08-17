using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class MovementController : MonoBehaviour
    {
        public Rigidbody2D RigidBody { get; private set; }
        private Vector2 Direction { get; set; } = Vector2.down;
        public float speed = 5f;

        public KeyCode inputUp = KeyCode.W;
        public KeyCode inputDown = KeyCode.S;
        public KeyCode inputLeft = KeyCode.A;
        public KeyCode inputRight = KeyCode.D;

        // public AnimatedSpriteRenderer spriteRendererUp;
        // public AnimatedSpriteRenderer spriteRendererDown;
        // public AnimatedSpriteRenderer spriteRendererLeft;
        // public AnimatedSpriteRenderer spriteRendererRight;
        // public AnimatedSpriteRenderer activeSpriteRenderer;
        // public AnimatedSpriteRenderer spriteRendererDeath;

        private void Awake()
        {
            RigidBody = GetComponent<Rigidbody2D>();
            // activeSpriteRenderer = spriteRendererDown;
        }

        private void Update()
        {
            UpdateMovementDirection();
        }
    
        private void UpdateMovementDirection()
        {
            if (Input.GetKey(inputUp))
                SetDirection(Vector2.up);
            else if (Input.GetKey(inputDown))
                SetDirection(Vector2.down);
            else if (Input.GetKey(inputLeft))
               SetDirection(Vector2.left);
            else if (Input.GetKey(inputRight))
                SetDirection(Vector2.right);
            else
                SetDirection(Vector2.zero);
        }

        private void SetDirection(Vector2 newDirection /*, AnimatedSpriteRenderer spriteRenderer*/)
        {
            Direction = newDirection;
            //
            // spriteRendererUp.enabled = spriteRenderer == spriteRendererUp;
            // spriteRendererDown.enabled = spriteRenderer == spriteRendererDown;
            // spriteRendererLeft.enabled = spriteRenderer == spriteRendererLeft;
            // spriteRendererRight.enabled = spriteRenderer == spriteRendererRight;
            //
            // activeSpriteRenderer = spriteRenderer;
            // activeSpriteRenderer.idle = Direction == Vector2.zero;
        }

        private void FixedUpdate()
        {
            RigidBody.MovePosition(NewPosition());
        }

        private Vector2 NewPosition()
        {
            return RigidBody.position + Direction * (speed * Time.fixedDeltaTime);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
           
        }
        
    }
}
