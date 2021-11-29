using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterAI : MonoBehaviour
{
    float dirX;
    float moveSpeed;
    Rigidbody2D rb2d; //il faut pouvoir accéder au rigidBody
    bool facingRight = false;
    Vector2 localScale;
    Animator animator;
    public string sceneName;
    GameObject player; //keep track of the player
    SpriteRenderer spriteRenderer;
    //public GameObject ignoreObjects;

    void Start()
    {
        localScale = transform.localScale;
        rb2d = GetComponent<Rigidbody2D>();
        dirX = -1f;
        moveSpeed = 3f;
        player = GameObject.FindGameObjectWithTag("Player");
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        //Physics2D.IgnoreCollision(GetComponent<Collider2D>(), ignoreObjects.GetComponent<Collider2D>());
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Wall")){
            dirX *= -1f;
        }
    }
    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(dirX *moveSpeed, rb2d.velocity.y);
    }
    void LateUpdate(){
        CheckWhereToFace();
    }
    void CheckWhereToFace(){
        if(dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;
        if(((facingRight) && (localScale.x < 0)) || ((facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }
}
