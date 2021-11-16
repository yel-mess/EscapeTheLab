using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClicked : MonoBehaviour, ISelectHandler
{
    // [HideInInspector]
    // public bool selected = false;

    //faire une vcariable qd l'item est sélectionner
    public static ItemData lastSelectedItem;
    void Start(){
    }
    public void Click(){
        Debug.Log(GetComponent<ItemView>().itemData.itemName);
        //Destroy(gameObject);
    }
    public void OnSelect(BaseEventData eventData){
        //selected = true;
        // Debug.Log(selected);
        lastSelectedItem = EventSystem.current.currentSelectedGameObject.GetComponent<ItemView>().itemData;
    }
}
