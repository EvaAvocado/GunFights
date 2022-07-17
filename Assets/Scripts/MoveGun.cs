using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class MoveGun : MonoBehaviour
{
    [SerializeField] private float speed;
    private float _positionY;
    
    private void Update()
    {
        // if (Input.touchCount > 0)
        // {
        //     if(Input.GetTouch(0).phase == TouchPhase.Began){
        //         _positionY = Input.GetTouch(0).position.y;
        //     }
        // }

        _positionY = Input.mousePosition.y;
        //print(_positionY);
        
        float top = Screen.height - 10;
        float middle = (Screen.height - 20) / 2;
        float bottom = 10;
        
        if (_positionY > bottom && _positionY <= top)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.Euler(0, 0, 30 - ((100/(top-bottom)) * (top - _positionY))), Time.deltaTime * speed);
        }
        
    }
}