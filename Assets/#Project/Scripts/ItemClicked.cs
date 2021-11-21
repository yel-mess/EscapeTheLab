using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClicked : MonoBehaviour, ISelectHandler //, IDeselectHandler
{
    // [HideInInspector]
    public static bool selected;

    [HideInInspector]
    public bool clicked;

    //faire une vcariable qd l'item est sélectionner
    //public GameObject playerPrefab;
    //PlayerController playerRigidBody;
    public static ItemData lastSelectedItem;
    void Start(){
        //player = Instantiate (Resources.Load ("shuffe(move)_0")) as GameObject;
        //player = GetComponent<GameObject>();
        //playerPrefab = Resources.Load("shuffe(move)_0") as GameObject;
        //var player = GameObject.Instantiate(playerPrefab, transform.position, transform.rotation);
    }
    public void Click(){
        Debug.Log(GetComponent<ItemView>().itemData.itemName);
        //Destroy(gameObject);
        //playerRigidBody.rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;
    }
    public void OnSelect(BaseEventData eventData){
        selected = true;
        // Debug.Log(selected);
        lastSelectedItem = EventSystem.current.currentSelectedGameObject.GetComponent<ItemView>().itemData;
    }
    // void FindPlayer(){
        
        
    // }

    public void OnDeselect(BaseEventData eventData){
        //playerRigidBody.rb2d.constraints = RigidbodyConstraints2D.None;
        selected = false;
    }
}
