using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverItem : MonoBehaviour
{
    public GameObject objectType; //Couloir A
    Vector2 mousePos;
    void Start()
    {
        objectType.SetActive(false);
    }
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objectType.transform.position = new Vector2(mousePos.x, mousePos.y-1);
    }
    void OnMouseOver() {
        objectType.SetActive(true);
        print("mouse over works");
    }
    void OnMouseExit() {
        objectType.SetActive(false);
    }
}
