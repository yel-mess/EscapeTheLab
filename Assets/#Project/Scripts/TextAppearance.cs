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
    //private bool objectIsActive = false;
    //private string text = "Couloir A";
    //private string currentToolTipText = "";
    //private string guiStyleFore = GUIStyle;

    void Start()
    {
        actionBox.SetActive(false);
        objectType.SetActive(false);
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(1) && actionIsActive == false) {
            actionBox.SetActive(true);
        }
        else if(Input.GetMouseButtonUp(1) && actionIsActive){
            actionBox.SetActive(false);
        }
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        objectType.transform.position = new Vector2(mousePos.x, mousePos.y-1);
        
    }
    // void OnMouseEnter() {
        
    //     objectIsActive = true;
    // }
    void OnMouseOver() {
        Debug.Log("Mouse is over GameObject");
        objectType.SetActive(true);
    }
    void OnMouseExit() {
        Debug.Log("Mouse is no longer on GameObject");
        objectType.SetActive(false);
    }
}
