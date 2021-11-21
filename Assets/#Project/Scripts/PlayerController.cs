using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private bool leftClickPressed = false;
    bool isMoving = true;
    //private Animator animator;
    
    public float movementSpeed = 10f;
    Vector2 lastClickedPos;
    private SpriteRenderer spriteRenderer;
    public ItemViewController itemViewController;
    
    [HideInInspector]
    public Rigidbody2D rb2d;

    ItemClicked itemClicked;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {

        if(leftClickPressed) {
            //isMoving = true;
            //récupère la position de la souris et bouge le joueur
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //isMoving = true;
            
        }
        if (lastClickedPos.x != transform.position.x) {
            if(lastClickedPos.x < transform.position.x && spriteRenderer.flipX == false) {
                //animator.SetBool("Left", true);
                spriteRenderer.flipX = true;
            }
            else if (lastClickedPos.x > transform.position.x && spriteRenderer.flipX == true) {
                spriteRenderer.flipX = false;
            }
            //float remainingDistance = lastClickedPos.x - transform.position.x;
            //Vector2 direction = new Vector2 (x, 0).normalized;
            //transform.position = new Vector2(transform.position += remainingDistance), 0).normalized * deplacement;

            float deplacement = movementSpeed * Time.deltaTime;
            lastClickedPos.y = 0f;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, deplacement);
        }
        //isMoving = false;
        leftClickPressed = false;
    }
    public void Move(InputAction.CallbackContext context) {
        if (context.performed) {
            leftClickPressed = true;
        }
    }
    public void StopMoving(){
        if(ItemClicked.selected){

        }
    }
}
//pos + (click - pos).normalised * mov
//pour calculer la dernière distance il faut prendre min de mouv et différence entre (pos - click)

//Vector2 pos
//Vector2 dir = pos.normalized