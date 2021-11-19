using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClicked : MonoBehaviour, ISelectHandler //, IDeselectHandler
{
    // [HideInInspector]
    // public bool selected = false;

    //faire une vcariable qd l'item est sélectionner
    public GameObject player;
    PlayerController playerRigidBody;
    public static ItemData lastSelectedItem;
    void Awake(){
        player = GameObject.FindGameObjectWithTag("Player");
        //player = GetComponent<GameObject>();
    }
    public void Click(){
        Debug.Log(GetComponent<ItemView>().itemData.itemName);
        //Destroy(gameObject);
        playerRigidBody.rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;
    }
    public void OnSelect(BaseEventData eventData){
        //selected = true;
        // Debug.Log(selected);
        lastSelectedItem = EventSystem.current.currentSelectedGameObject.GetComponent<ItemView>().itemData;
    }
    // public void OnDeselect(BaseEventData eventData){
    //     playerRigidBody.rb2d.constraints = RigidbodyConstraints2D.None;
    // }
}
