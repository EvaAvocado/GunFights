using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

namespace Guns
{
    public class FriendlyGun : Gun
    {
        
        protected override void MoveGun()
        {
            if (positionY > bottom && positionY <= top)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation,
                    Quaternion.Euler(0, 0, 30 - ((70 / (top - bottom)) * (top - positionY))), Time.deltaTime * speed);
            }
        }

        protected override void Fire()
        {
            base.Fire();
        }
    }
}