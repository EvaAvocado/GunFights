using UnityEngine;
using UnityEngine.Events;
using Util;

namespace Guns
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] protected float speed;
        [SerializeField] private Cooldown _fireCooldown;
        
        [SerializeField] private UnityEvent _fireAction;
        
        protected float positionY;
        protected float top = Screen.height;
        protected float bottom = 0;

        private void Update()
        {
            positionY = Input.mousePosition.y;
            
            MoveGun();
            Fire();
        }

        protected virtual void MoveGun()
        {

        }

        protected virtual void Fire()
        {
            if (positionY > bottom && positionY <= top)
            {
                if (_fireCooldown.IsReady)
                {
                    _fireAction?.Invoke();
                    _fireCooldown.Reset();
                }
            }
        }
    }
}