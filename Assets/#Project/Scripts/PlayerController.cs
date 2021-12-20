using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

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
    public Button button;
    
    Animator animator;
    public bool facingRight = true;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        GameObject popUpButtonGo = GameObject.FindGameObjectWithTag("PopUpButton");
        if (button == null)
        {
            if (popUpButtonGo == null)
            {
                Debug.LogError("No object with PopupButton tag in this scene.");
            }
            button = popUpButtonGo.GetComponent<Button>();
        }
        button.onClick.AddListener(TaskOnClick);
        print(transform.localScale);
    }
    void Update() {

        if(ItemClicked.usingItem){
            leftClickPressed = false;
            lastClickedPos.x = transform.position.x;
        }
        if(!ItemClicked.usingItem){
            if(leftClickPressed) {
            
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

            if (lastClickedPos.x != transform.position.x) {
                animator.SetBool("Moving", true);
                if(lastClickedPos.x < transform.position.x && transform.localScale.x == 1) {
                    Flip();
                }
                else if (lastClickedPos.x > transform.position.x && transform.localScale.x == -1) {
                    Flip();
                }
                
                deplacement = movementSpeed * Time.deltaTime;
                lastClickedPos.y = 1.58f;
                transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, deplacement);
                
                //print("test move");
            }
            else
            {
                animator.SetBool("Moving", false);
            }
            //isMoving = false;
            
            leftClickPressed = false;
        }
        
    }
    void TaskOnClick()
    {
        leftClickPressed = false;
        lastClickedPos.x = transform.position.x;
    }
    void Flip()
    {
        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale;
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