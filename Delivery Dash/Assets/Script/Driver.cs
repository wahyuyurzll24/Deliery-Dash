using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.8f;
    [SerializeField] float moveSpeed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        float move = 0f;
        float steer = 0f;
        
        if (Keyboard.current.wKey.isPressed)
        {
            move = 0.1f;
            
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -0.1f;
        }
         if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
         else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }
     









        transform.Rotate(0, 0, steer * steerSpeed);
        transform.Translate(0, move * moveSpeed, 0);
    }
}
