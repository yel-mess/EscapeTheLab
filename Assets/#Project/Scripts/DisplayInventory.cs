using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayInventory : MonoBehaviour, IPointerClickHandler 
{
    //Button bagButton;
    public GameObject inventory;
    //public GameObject[] slots;
    private bool inventoryIsActive = false;
 
    //public Sprite[] slots;
    void Start()
    {
        // foreach (var item in slots)
        // {
        //     item.SetActive(false);
        // }

        inventory.SetActive(false);
        //bagButton.onClick.AddListener(showInventory);
    }

    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData){
        if(Input.GetMouseButtonUp(1)){
            inventoryIsActive = !inventoryIsActive;
            inventory.SetActive(inventoryIsActive);
        }
    }
    // public void showInventory(){
    //     Debug.Log("Button Clicked !");
    //     if(Input.GetMouseButtonUp(1) && inventoryIsActive == false){
    //         // foreach (var item in slots)
    //         // {
    //         //     item.SetActive(true);
    //         // }
    //         inventoryIsActive = true;
    //         gameObject.SetActive(true);
    //     }
    //     else {
    //         // foreach (var item in slots)
    //         // {
    //         //     item.SetActive(false);
    //         // }
    //         inventoryIsActive = false;
    //         gameObject.SetActive(false);
    //     }
    // }
}
