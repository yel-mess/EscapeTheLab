using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    public ItemData itemData;
    public string popUp;

    void OnMouseOver(){
        if(Input.GetMouseButtonUp(1)){
            //description de l'item (texte aparait)
            PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
            pop.PopUp(popUp);
            FindObjectOfType<Inventory>().AddItem(itemData);
            Destroy(gameObject);
        }
    }
}
