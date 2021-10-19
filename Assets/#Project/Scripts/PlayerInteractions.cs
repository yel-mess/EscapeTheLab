using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractions : MonoBehaviour
{
    [HideInInspector]
    public bool rightClickPressed = false;
    //private PickUp pickUp;
    private Inventory inventory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rightClickPressed) {
        }
        rightClickPressed = false;
    }
    public void Interact(InputAction.CallbackContext context) {
        if (context.performed) {
            rightClickPressed = true;
            Debug.Log("Interact works");
        }
    }
}
