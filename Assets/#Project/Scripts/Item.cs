using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    //private bool ItemPickedUp = false;
    //[HideInInspector]
    //public bool ItemIsdestroyed = false;
    public ItemData itemData;
    public string popUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver(){
        if(Input.GetMouseButtonUp(1)){
            //description de l'item (texte aparait)
            PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
            pop.PopUp(popUp);
            FindObjectOfType<Inventory>().AddItem(itemData);
            Destroy(gameObject);
            //ItemIsdestroyed = true;
        }
    }
}
