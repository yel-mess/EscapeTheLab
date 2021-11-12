using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class MonsterAI : MonoBehaviour
{
    //temporary
    public float agroRange;
    Animator animator;
    [SerializeField]
    float deathRange;
    public float hitRange;
    public float moveSpeed;
    //GameObject notice;

    [SerializeField]
    GameObject player; //keep track of the player
    Rigidbody2D rb2d; //il faut pouvoir accéder au rigidBody
    SpriteRenderer spriteRenderer;
    //public UnityEvent whenTouchPlayer;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Vector2 start;
        // Vector2 direction;
        
        
        //distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.transform.position);

        #region monstre se déplace à gauche ou à droite


        // if(moveSpeed.x < 0) {
        //     if(animator != null) {
        //         //flip
        //         animator.SetBool("Right", false);
        //     }
        //     else {
        //         spriteRenderer.flipX = false;
        //     }
        //     start = (Vector2)transform.position + Vector2.left * 0.51f;
        //     direction = Vector2.left;
        // }
        // //modifier pour que le monstre ne flippe pas (animation iddle ?)
        // else {
        //     if (animator != null) { //si pas d'animation, flippe
        //         animator.SetBool("Right", true);
        //     }
        //     else {
        //         spriteRenderer.flipX = true;
        //     }
        //     //change if problems occur
        //     spriteRenderer.flipX = false;
        //     start = (Vector2)transform.position + Vector2.right * 0.51f;
        //     direction = Vector2.right;
        // }

        #endregion
        
        //monster needs to follow the player after it emerges from hiding spots
        //use ray cast ? (check 2DGameThingy)

        // Debug.DrawRay(start, direction * hitRange, Color.blue);
        // RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        // Vector2 deplacement = moveSpeed * Time.deltaTime;
        // transform.position += (Vector3)deplacement;

        if(distToPlayer < agroRange){
            ChasePlayer();
        }
        else {
            StopChasingPlayer();
        }

        // if(distToPlayer < deathRange){
        //     //kills the player
        //     KillPlayer();
        // }
    }
    void ChasePlayer(){
        //si le monstre est à gauche, il se retourne et bouge
        if(transform.position.x < player.transform.position.x){
            rb2d.velocity = new Vector2(moveSpeed, 0);
            animator.SetBool("Right", true);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), moveSpeed * Time.deltaTime);
        }
        else {
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            animator.SetBool("Right", false);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), moveSpeed * Time.deltaTime);
        }
        animator.SetBool("Notice", true);
    }
    void StopChasingPlayer(){
        rb2d.velocity = Vector2.zero;
        animator.SetBool("Notice", false);
    }
    void OnTriggerEnter2D(Collider2D collision){
        // if(collision.CompareTag("Player")){
        //     whenTouchPlayer?.Invoke();
        //     Destroy(player);
        // }
        if(collision.CompareTag("Player")){
            Debug.Log("GAME OVER");
        }
    }
}
