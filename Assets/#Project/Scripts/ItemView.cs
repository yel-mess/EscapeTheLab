using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

// responsible for carrying data, visual references, on click action and initial state for injecting item data.
public class ItemView : MonoBehaviour
{
    public Button button;
    public Image ItemIcon;

    //UnityEvent UseItem = new UnityEvent();
    
    [HideInInspector]
    public ItemData itemData;
    ItemViewController itemViewController;

    // void Start(){
    //     UseItem.AddListener(RemoveItem);
    // }
    // void Update(){
    //     if(UseItem == null){
    //         UseItem.Invoke();
    //     }
    // }
    public void InitItem(ItemData item) {
        this.itemData = item;
        ItemIcon.sprite = itemData.icon;
    }
    // public void ButtonClicked(){
    //     selected = true;
    //     button.onClick.AddListener(RemoveItem);
    // }
    public void RemoveItem() {
        // Debug.Log("Removing item...");
        // this.itemData = null;
        // Destroy(this.itemViewController.itemViewPrefab);
        // this.itemViewController.itemViewPrefab = null;
        // selected = false;
        // Debug.Log("Item removed !");
    }
}
