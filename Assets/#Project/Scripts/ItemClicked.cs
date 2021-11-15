using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClicked : MonoBehaviour
{
    [HideInInspector]
    public bool selected = false;
    void Start(){
    }
    public void Click(){
        selected = true;
        Debug.Log(selected);
        Debug.Log(GetComponent<ItemView>().itemData.name);
        //effacer l'item

        //Destroy(gameObject);
    }
}
