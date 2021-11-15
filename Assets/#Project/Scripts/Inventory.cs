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
    public void UseItem(ItemData item){
        //inventory.Remove(item);
        //itemViewController.UpdateView();

        // int index = -1;
        // for (int i = 0; i < inventory.Count; i++)
        // {
        //     if(inventory[i] == item){
        //         index = i;
        //         break;
        //     }
        //     if(index == -1){
        //         Debug.Log("Item not found in inventory");
        //         return;
        //     }
        //     inventory[index] = null;

        // }
        // inventory.Remove(item);
        // itemViewController.UpdateView();
        //le boutton utilise la méthode
        //si l'item correspond à l'icône requis sur l'objet
        //l'item dans l'inventaire se détruit
    }
    private void Update() 
    {

    }

}
