using UnityEngine;
using UnityEngine.InputSystem;

public class KeybindMananger : MonoBehaviour
{
   

    
    void Update()
    {
       if (Keyboard.current.qKey.isPressed)
        {
            Application.Quit();
        }   
    }
}

