using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClicked : MonoBehaviour, ISelectHandler
{
    // [HideInInspector]
    // public bool selected = false;

    //faire une vcariable qd l'item est sélectionner
    public GameObject player;
    PlayerController playerRigidBody;
    public static ItemData lastSelectedItem;
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Click(){
        Debug.Log(GetComponent<ItemView>().itemData.itemName);
        //Destroy(gameObject);
        playerRigidBody.rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    public void OnSelect(BaseEventData eventData){
        //selected = true;
        // Debug.Log(selected);
        lastSelectedItem = EventSystem.current.currentSelectedGameObject.GetComponent<ItemView>().itemData;
    }
}
