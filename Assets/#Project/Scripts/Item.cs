using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    //private bool ItemPickedUp = false;
    public ItemData itemData;

    //public string popUp;
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnMouseOver(){
        if(Input.GetMouseButtonUp(1)){
            //description de l'item (texte aparait)
            PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
            pop.PopUp();
            FindObjectOfType<Inventory>().AddItem(itemData);
            Destroy(gameObject);
        }
    }
}
