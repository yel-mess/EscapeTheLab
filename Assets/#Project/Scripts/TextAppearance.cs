using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextAppearance : MonoBehaviour
{
    [HideInInspector]
    private bool actionIsActive = false;
    private bool objectIsActive = false;

    public GameObject ActionBox; //Open
    public GameObject ObjectType; //Couloir A

    void Start()
    {
        ActionBox.SetActive(false);
        ObjectType.SetActive(false);
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(1) && actionIsActive == false) {
            ActionBox.SetActive(true);
        }
        else if(Input.GetMouseButtonUp(1) && actionIsActive){
            ActionBox.SetActive(false);
        }
    }
    void OnMouseEnter() {
        
        objectIsActive = true;
    }
    void OnMouseOver() {
        if(objectIsActive) {
            ObjectType.SetActive(true);
        }
    }
    void OnMouseExit() {
        ObjectType.SetActive(false);
    }
}
