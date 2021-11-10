using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    [SerializeField]
    GameObject player; //keep track of the player

    [SerializeField]
    float deathRange;

    [SerializeField]
    float moveSpeed;
    Rigidbody2D rb2d; //il faut pouvoir accéder au rigidBody
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.transform.position);

        //monster needs to follow the player after it emerges from hiding spots
        //use ray cast ? (check 2DGameThingy)

        if(distToPlayer < deathRange){
            //kills the player the player
        }
    }
    void ChasePlayer(){

    }
    void StopChasingPlayer(){
        
    }
}
