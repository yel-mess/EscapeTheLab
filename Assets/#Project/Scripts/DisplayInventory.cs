using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    Button bagButton;
    //public GameObject inventory;
    public GameObject[] slots;
    private bool inventoryIsActive = false;
    //public Sprite[] slots;
    void Start()
    {
        foreach (var item in slots)
        {
            item.SetActive(false);
        }

        //inventory.SetActive(false);
        bagButton.onClick.AddListener(showInventory);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showInventory(){
        Debug.Log("Button Clicked !");
        if(Input.GetMouseButtonUp(1) && inventoryIsActive == false){
            foreach (var item in slots)
            {
                item.SetActive(true);
            }
            inventoryIsActive = true;
            //inventory.SetActive(true);
        }
        else {
            foreach (var item in slots)
            {
                item.SetActive(false);
            }
            inventoryIsActive = false;
        }
    }
}
