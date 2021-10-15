using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppearance : MonoBehaviour
{
    [HideInInspector]
    public Text text;
    public GameObject ActionBox; //Open
    public GameObject ObjectType; //Couloir A

    void Start()
    {
        ActionBox.SetActive(false);
        ObjectType.SetActive(false);
    }

    void Update()
    {
        Click();
    }
    public void OnMouseOver() {
        
        ObjectType.SetActive(true);
        
    }
    public void OnMouseExit() {
        ObjectType.SetActive(false);
    }
    public void Click() {
        if(Input.GetMouseButtonUp(1)) {
            ActionBox.SetActive(true);
        }
    }
}
