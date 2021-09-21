using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private bool leftClickPressed = false;
    private void Awake() { //Awake se lance avant le Start
        
    }
    
    private void OnEnable() { //Est appelé quand les script est activé
        
    }
    private void OnDisable() {
        
    }
    void Start() {
    }
    void Update() {
        if(leftClickPressed) {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePos.x, mousePos.y);
            leftClickPressed = false;
        }
    }
    public void Move(InputAction.CallbackContext context) {
        if (context.performed) {
            leftClickPressed = true;
            Debug.Log("OK !");
        }
    }
    public void Interact(InputAction.CallbackContext context) {
        if (context.performed)
            Debug.Log("I'm doing something !");
    }
}
