using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //private Vector2 targetPosition; //position de la souris
    private PlayerActionControls playerActionControls;
    private void Awake() { //Awake se lance avant le Start
        playerActionControls = new PlayerActionControls();
    }
    private void OnEnable() { //Est appelé quand les script est activé
        playerActionControls.Enable();
    }
    private void OnDisable() { //Est appelé quand les script est activé
        playerActionControls.Disable();
    }
    void Start() {
        //targetPostion = transform.position.x;
    }
    void Update() {
        //Retrieve the mouse position
    //     if(Input.GetKeyDown(KeyCode.Mouse0)) //???
    //     {  
    //         targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //???
    //     }
    //     transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
        // Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //récup les coordonnées de la position de la souris dans le jeu
        // Debug.Log(mousePos);
        playerActionControls.Gameplay.Move.ReadValue<float>();
    }
    public void Move(InputAction.CallbackContext context) {
        if (context.performed)
        Debug.Log("OK !");
    }
    public void Interact(InputAction.CallbackContext context) {
        if (context.performed)
        Debug.Log("I'm doing something !");
    }
}
