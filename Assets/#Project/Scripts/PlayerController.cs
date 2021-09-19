using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public void Move(InputAction.CallbackContext context) {
        if (context.performed)
        Debug.Log("OK !");
    }
    public void Interact(InputAction.CallbackContext context) {
        if (context.performed)
        Debug.Log("I'm doing something !");
    }
}
