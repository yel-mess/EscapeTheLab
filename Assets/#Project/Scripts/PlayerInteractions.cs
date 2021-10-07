using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractions : MonoBehaviour
{
    private bool rightClickpressed = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact(InputAction.CallbackContext context) {
        if (context.performed) {
            Debug.Log("I'm doing something !");
            rightClickpressed = true;
        }
    }
}
