using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public bool leftClickPressed = false;
    public float movementSpeed = 5f;
    //public bool isMoving = true;

    public Vector2 lastClickedPos;
    private SpriteRenderer spriteRenderer;
    public ItemViewController itemViewController;

    [HideInInspector]
    public float deplacement;
    
    [HideInInspector]
    public Rigidbody2D rb2d;
    ItemClicked itemClicked;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {

        if(ItemClicked.usingItem){
            leftClickPressed = false;
            lastClickedPos.x = transform.position.x;
        }
        if(!ItemClicked.usingItem){
            //Debug.Log(itemIsSelected);
            if(leftClickPressed) {
                //print("last poistion");
            //récupère la position de la souris et bouge le joueur
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
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

                deplacement = movementSpeed * Time.deltaTime;
                lastClickedPos.y = 1f;
                transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, deplacement);
                //print("test move");
            }
            //isMoving = false;
            leftClickPressed = false;
        }
        
    }
    public void Move(InputAction.CallbackContext context) {
        if (context.performed) {
            //print("click to move");
            leftClickPressed = true;
        }
    }
}
//pos + (click - pos).normalised * mov
//pour calculer la dernière distance il faut prendre min de mouv et différence entre (pos - click)

//Vector2 pos
//Vector2 dir = pos.normalized