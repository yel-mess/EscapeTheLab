using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemData> inventory  = new List<ItemData>();
    ItemViewController itemViewController;

    int index = 0;


private void Start(){
    itemViewController = FindObjectOfType<ItemViewController>();
    if(itemViewController==null){
        Debug.LogError("There is no ItemViewController in your scene.");
    }
}

public void AddItem(ItemData item){
   inventory.Add(item);
   itemViewController.UpdateView();

}
    private void Update() 
    {
        // if (Input.GetKeyDown(KeyCode.Space))    
        // {
        //     NextItemInfo();
        // }
    }

    // public void NextItemInfo()
    // {
    //     if (index > inventory.Length)
    //     {
    //         index = 0;
    //     }

    //     Debug.Log("Item name: " + inventory[index].name);
    //     Debug.Log ("Description: " + inventory[index].description);

    //     switch(inventory[index].type)
    //     {
    //         case ItemType.IDCard1: 
    //         Debug.Log("Item type: IDCard1"); 
    //         break;

    //         case ItemType.TinCans: 
    //         Debug.Log("Item type: TinCans");
    //         break;

    //         case ItemType.IDCard2: 
    //         Debug.Log("Item type: IDCard2");
    //         break;

    //         case ItemType.UVLamp: 
    //         Debug.Log("Item type: UVLamp"); 
    //         break;

    //         case ItemType.Screwdriver: 
    //         Debug.Log("Item type: Screwdriver"); 
    //         break;

    //         case ItemType.Batteries: 
    //         Debug.Log("Item type: Batteries"); 
    //         break;
    //     }

    //     index ++;
    // }

}
