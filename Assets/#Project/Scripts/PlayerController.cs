using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private bool leftClickPressed = false;
    public float movementSpeed = 0f;
    //private bool isMoving;
    Vector2 lastClickedPos;
    //Vector2 destination;
    private SpriteRenderer spriteRenderer;

    void Start() {
        //destination = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        //animator = GetComponent<Animator>();
    }

    // Move to the target end position.
    void Update() {
        if(leftClickPressed) {
            
            //récupère la position de la souris et bouge le joueur
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float deplacement = movementSpeed * Time.deltaTime;

            if (lastClickedPos.x > transform.position.x) {

                //bouger à droite
                Debug.Log("Je vais à droite");
                transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, deplacement);
                //transform.position = new Vector2(lastClickedPos.x, transform.position.y);
            }
            else {

                //bouger à gauche
                Debug.Log("Je vais à gauche");
                //transform.position = new Vector2(lastClickedPos.x, transform.position.y);
                transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, deplacement);
            }

            //Vector2 movement = new Vector2(mousePos.x, transform.position.y) * movementSpeed;

            //transform.position = new Vector2(mousePos.x, transform.position.y);
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
