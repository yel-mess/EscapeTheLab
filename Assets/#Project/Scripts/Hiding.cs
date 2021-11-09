using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hiding : MonoBehaviour, IPointerClickHandler
{
    public GameObject player;
    private bool isHiding = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData){
        if(Input.GetMouseButtonUp(1)){
            isHiding = !isHiding;
            Debug.Log("Hiding !!");
        }
    }
}
