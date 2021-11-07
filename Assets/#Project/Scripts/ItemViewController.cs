using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemViewController : MonoBehaviour
{
    public Inventory inventoryHolder; //references a Inventory qui contient ItemData
    public Transform inventoryViewParent; //references à Transform pour créer des objets ItemView en tant qu'enfant de Inventory view dans la scène
    //public Transform infoViewParent; // montre qui va être le parent the "view"

    //private GameObject infoViewPrefab; // stocker une reference à ViewInfo dans Start
    public GameObject itemViewPrefab; // L'ItemView sauvegardé dans Prefab

    //private GameObject infoView;

    private void Start() 
    {
        // itemViewPrefab = (GameObject)Resources.Load("Item");
        // infoViewPrefab = (GameObject)Resources.Load("InfoView");

        //créer une instance de ItemView et on appelle la méthode InitItem pour l'initialiser avec ItemData pour chaque item dans l'inventaire
        foreach (var item in inventoryHolder.inventory)
        {
            var itemGO = GameObject.Instantiate(itemViewPrefab, inventoryViewParent);
            itemGO.GetComponent<ItemView>().InitItem(item);
        }
    }

    // Instantier view dans la scene
    // private void CreateInfoView(ItemData data) {
    //     if(infoView != null) {
    //         Destroy(infoView);
    //     }
    //     var infoGO = GameObject.Instantiate(infoViewPrefab, infoViewParent);
    //     infoGO.GetComponent<InfoView>().Init(data);
    // }
}
