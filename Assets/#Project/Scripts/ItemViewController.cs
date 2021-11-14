using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemViewController : MonoBehaviour
{
    public Inventory inventoryHolder; //references a Inventory qui contient ItemData
    public Transform inventoryViewParent; //references à Transform pour créer des objets ItemView en tant qu'enfant de Inventory view dans la scène
    public GameObject itemViewPrefab; // L'ItemView sauvegardé dans Prefab

    Dictionary<ItemData, GameObject> itemsDisplayed = new Dictionary<ItemData, GameObject>();
    int index = 0;

    private void Start()
    {
        UpdateView();
    }
    public void UpdateView()
    {
        //créer une instance de ItemView et on appelle la méthode InitItem pour l'initialiser avec ItemData pour chaque item dans l'inventaire

        for (int i = 0; i < inventoryHolder.inventory.Count; i++)
        {
            Debug.Log("adding item : " + index);
            if (!itemsDisplayed.ContainsKey(inventoryHolder.inventory[i]))
            {
                var itemGO = GameObject.Instantiate(itemViewPrefab, inventoryViewParent);
                itemGO.GetComponent<ItemView>().InitItem(inventoryHolder.inventory[i]);
                itemsDisplayed.Add(inventoryHolder.inventory[i], itemGO);
            }
            index++;
            Debug.Log(inventoryHolder.inventory.Count);
            // if(inventoryHolder.inventory.Count < i){
            //     break;
            // }
        }
    }
    void Update()
    {
        //if(item.ItemIsdestroyed == true){
        //   Debug.Log("Item is in inventory !");
        //}
    }
}
