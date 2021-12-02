using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemData> inventory  = new List<ItemData>();
    ItemViewController itemViewController;

    private void Start(){
        itemViewController = FindObjectOfType<ItemViewController>();
        if(itemViewController == null){
            Debug.LogError("There is no ItemViewController in your scene.");
        }
    }

    public void AddItem(ItemData item){
        inventory.Add(item);
        itemViewController.UpdateView();
    }
    public void RemoveItem(){
        Debug.Log("inventory full");
        //inventory = new List<ItemData>();
        inventory.Clear();
        Debug.Log("inventory empty");
        itemViewController.UpdateView();
    }
    private void Update() 
    {

    }

}
