using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private bool leftClickPressed = false;
    //private GameObject gameObject;
    public Vector2 speed = Vector2.zero;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private void Awake() { //Awake se lance avant le Start
        
    }
    
    private void OnEnable() { //Est appelé quand les script est activé
        
    }
    private void OnDisable() {
        
    }
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update() {
        if(leftClickPressed) {
            //récupère la position de la souris et bouge le joueur
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = new Vector2(mousePos.x, transform.position.y);
            //flip le joueur
            if(spriteRenderer == false) {
                spriteRenderer.flipX = true;
            }
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
