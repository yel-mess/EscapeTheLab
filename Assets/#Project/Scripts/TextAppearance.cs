using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextAppearance : MonoBehaviour
{
    [HideInInspector]
    private bool actionIsActive = false;
    public GameObject actionBox; //Open
    public GameObject objectType; //Couloir A
    Vector2 mousePos;

    void Start()
    {
        actionBox.SetActive(false);
        objectType.SetActive(false);
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        objectType.transform.position = new Vector2(mousePos.x, mousePos.y-1);
        
    }
    void OnMouseOver() {
        objectType.SetActive(true);
        if(Input.GetMouseButtonUp(1) && actionIsActive == false) {
            actionBox.SetActive(true);
        }
        else if(Input.GetMouseButtonUp(1) && actionIsActive){
            actionBox.SetActive(false);
        }
    }
    void OnMouseExit() {
        objectType.SetActive(false);
    }
}
