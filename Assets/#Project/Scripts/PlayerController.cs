using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private bool leftClickPressed = false;
    public float movementSpeed;
    private bool isMoving;
    Vector2 lastClickedPos;
    private SpriteRenderer spriteRenderer;
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //animator = GetComponent<Animator>();
    }
    void Update() {
        if(leftClickPressed) {
            //SetTargetPosition(); // méthode pour enregistrer la position de la souris
            
            //récupère la position de la souris et bouge le joueur
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMoving = true;
            if(isMoving && (Vector2)transform.position != lastClickedPos) {
                float step = movementSpeed * Time.deltaTime;
                transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
            }
            else {
                isMoving = false;
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
