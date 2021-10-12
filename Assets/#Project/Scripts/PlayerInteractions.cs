using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractions : MonoBehaviour
{
    [HideInInspector]
    public bool rightClickPressed = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact(InputAction.CallbackContext context) {
        if (context.performed) {
            rightClickPressed = true;
            Debug.Log("Interact works");
        }
    }
}
