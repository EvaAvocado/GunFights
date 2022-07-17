using UnityEngine;

namespace Guns
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _power;
        private Rigidbody2D _rb;

        private float _cursorY;
        private float _top = Screen.height;
        private float _bottom = 0;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        
        private void Start()
        {
            _cursorY = Input.mousePosition.y;
            var delta = (_power / (_top - _bottom)) * _cursorY;
            
            _rb.AddForce(delta * Vector2.up + Vector2.right * _power, ForceMode2D.Impulse);
        }
    }
}