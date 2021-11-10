using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    [SerializeField]
    GameObject player; //keep track of the player

    [SerializeField]
    float deathRange;

    public Vector2 moveSpeed = Vector2.zero;
    Rigidbody2D rb2d; //il faut pouvoir accéder au rigidBody
    SpriteRenderer spriteRenderer;
    public float hitRange;
    Animator animator;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 start;
        Vector2 direction;

        //distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.transform.position);

        if(moveSpeed.x < 0) {
            if(animator != null) {
                //flip
                animator.SetBool("Right", false);
            }
            else {
                spriteRenderer.flipX = false;
            }
            start = (Vector2)transform.position + Vector2.left * 0.51f;
            direction = Vector2.left;
        }
        else {
            if (animator != null) { //si pas d'animation, flippe
                animator.SetBool("Right", true);
            }
            else {
                spriteRenderer.flipX = true;
            }
            //change if problems occur
            spriteRenderer.flipX = false;
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            direction = Vector2.right;
        }

        //monster needs to follow the player after it emerges from hiding spots
        //use ray cast ? (check 2DGameThingy)

        Debug.DrawRay(start, direction * hitRange, Color.blue);
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        Vector2 deplacement = moveSpeed * Time.deltaTime;
        transform.position += (Vector3)deplacement;

        if(distToPlayer < deathRange){
            //kills the player
        }
    }
    void ChasePlayer(){

    }
    void StopChasingPlayer(){

    }
    void KillPlayer(){
        
    }
}
