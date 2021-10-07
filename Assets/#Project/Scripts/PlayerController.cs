using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private bool leftClickPressed = false;
    //private bool isMoving;
    //private bool rightClickpressed = false;
    public float movementSpeed = 10f;
    Vector2 lastClickedPos;
    private SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //animator = GetComponent<Animator>();
    }

    void Update() {

        if(leftClickPressed) {
            
            //récupère la position de la souris et bouge le joueur
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //isMoving = true;
            
        }
        if (lastClickedPos != (Vector2)transform.position) {
            float deplacement = movementSpeed * Time.deltaTime;
            //float remainingDistance = lastClickedPos.x - transform.position.x;
            //Vector2 direction = new Vector2 (x, 0).normalized;
            //transform.position = new Vector2(transform.position += remainingDistance), 0).normalized * deplacement;

            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, deplacement);
        
        }
            
        leftClickPressed = false;
    }
    public void Move(InputAction.CallbackContext context) {
        if (context.performed) {
            leftClickPressed = true;
        }
    }
    public void Interact(InputAction.CallbackContext context) {
        if (context.performed) {
            Debug.Log("I'm doing something !");
            //rightClickpressed = true;
        }
    }
    
}
//pos + (click - pos).normalised * mov
//pour calculer la dernière distance il faut prendre min de mouv et différence entre (pos - click)

//Vector2 pos
//Vector2 dir = pos.normalized