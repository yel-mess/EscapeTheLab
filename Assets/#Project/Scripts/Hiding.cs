using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hiding : MonoBehaviour
{
    public GameObject player;
    //public Sprite hidingSpot;
    private bool isHiding = false;

    void Awake(){
        //player.SetActive(true);
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver(){
        if(Input.GetMouseButtonUp(1)){
            Debug.Log("Click detected");
            isHiding = !isHiding;
            Debug.Log(isHiding);
            player.SetActive(!isHiding);
        }
    }
}
