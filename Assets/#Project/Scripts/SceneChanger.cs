using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;

    //= Gamebject.Find("Item").GetComponent<ItemClicked>();
    public ItemData itemData;
    //public Gameobject itemPrefab;
    public ItemData requiredItem;
    public bool isOpen = false;
    //Inventory itemInventory;
    void Start(){
        
    }
    void OnMouseOver() {
        if(Input.GetMouseButtonUp(1)){
            CheckIfCorrect();
        }
        //s'il n y a pas d'item --> ouvre
        //si l'item correspond --> ouvre
        //si l'item ne correspond pas --> ferme
    }
    public void CheckIfCorrect(){

        //porte fermée, infranchissable
        if(!isOpen && requiredItem == null){
            Debug.Log("Door is locked");
        }
        //porte fermée, peut s'ouvrir grâce à un objet
        else if (!isOpen && requiredItem != null){
            
            if(ItemClicked.lastSelectedItem != null && requiredItem == ItemClicked.lastSelectedItem){
                Debug.Log("correct item !");
                isOpen = true;
                SceneManager.LoadScene(sceneName);
            }
                
            //Debug.Log("Door is locked but you could open it");
        }

        //porte ouverte
        else {
            SceneManager.LoadScene(sceneName);
        }
        // if(itemClicked.selected){
        //     //si requiredItem == l'icône de l'item
        //     if(requiredItem == GetComponent<ItemView>().itemData.icon){
        //         isOpen = true;
        //         SceneManager.LoadScene(sceneName);
        //     }
        // }
    }
}
