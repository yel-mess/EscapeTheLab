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

    void Start()
    {
        actionBox.SetActive(false);
    }

    void Update()
    {
        
    }
    void OnMouseOver() {
        if(Input.GetMouseButtonUp(1) && actionIsActive == false) {
            actionBox.SetActive(true);
        }
        else if(Input.GetMouseButtonUp(1) && actionIsActive){
            actionBox.SetActive(false);
        }
    }
}
