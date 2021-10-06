using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private bool leftClickPressed = false;
    public float movementSpeed = 1f;
    Vector2 lastClickedPos;
    private SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //animator = GetComponent<Animator>();
    }

    void Update() {

        float deplacement = movementSpeed * Time.deltaTime;

        if(leftClickPressed) {
            
            //récupère la position de la souris et bouge le joueur
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (lastClickedPos.x > transform.position.x) {

                //bouger à droite

                // Debug.Log("Je vais à droite");
                // Vector2 right = Vector2.right;
                // Vector2 translation = right * deplacement;
                // transform.Translate(translation);

                transform.position = Vector2.Lerp(transform.position, lastClickedPos, deplacement);

                //transform.position = new Vector2(lastClickedPos.x, transform.position.y);
            }
            else {

                //bouger à gauche
                Debug.Log("Je vais à gauche");
                //transform.position = new Vector2(lastClickedPos.x, transform.position.y);
                transform.position = Vector2.Lerp(transform.position, lastClickedPos, deplacement);
            }
            //Vector2 movement = new Vector2(mousePos.x, transform.position.y) * movementSpeed;

            //transform.position = new Vector2(mousePos.x, transform.position.y);
            
        }
        leftClickPressed = false;
    }
    public void Move(InputAction.CallbackContext context) {
        if (context.performed) {
            leftClickPressed = true;
        }
    }
    public void Interact(InputAction.CallbackContext context) {
        if (context.performed)
            Debug.Log("I'm doing something !");
    }
    
}
