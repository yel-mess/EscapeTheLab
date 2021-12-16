 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemViewController : MonoBehaviour
{
    public Inventory inventoryHolder; //references a Inventory qui contient ItemData
    public Transform inventoryViewParent; //references à Transform pour créer des objets ItemView en tant qu'enfant de Inventory view dans la scène
    public GameObject itemViewPrefab; // L'ItemView sauvegardé dans Prefab

    [HideInInspector]
    public GameObject itemGO = null;

    [HideInInspector]
    public Dictionary<ItemData, GameObject> itemsDisplayed = new Dictionary<ItemData, GameObject>();
    ItemView itemView;
    Menu menu;
    //int index = 0;

    private void Start()
    {
        UpdateView();
    }
    public void UpdateView()
    {
        foreach (ItemData itemData in itemsDisplayed.Keys) {
            Destroy(itemsDisplayed[itemData]);
        }
        itemsDisplayed.Clear();
        //créer une instance de ItemView et on appelle la méthode InitItem pour l'initialiser avec ItemData pour chaque item dans l'inventaire
        for (int i = 0; i < inventoryHolder.inventory.Count; i++)
        {
            if (!itemsDisplayed.ContainsKey(inventoryHolder.inventory[i]))
            {
                itemGO = GameObject.Instantiate(itemViewPrefab, inventoryViewParent);
                itemGO.GetComponent<ItemView>().InitItem(inventoryHolder.inventory[i]);
                itemsDisplayed.Add(inventoryHolder.inventory[i], itemGO);
            }
            // faire en sorte d'updater la view pour la reseter
            //s'il y a un item dans l'inventaire et que le jeu recommence --> effacer l'inventaire
            
        }
        //pour chaque objets dans l'inventaire

            //si l'item se trouve dans l'inventaire ET qu'il correspond à l'objet correspondant
            //OU
            //si on a cliqué sur le boutton ET que l'item corresepond à l'objet correspondant
            //alors on retire l'item

    }
    void Update()
    {
        
    }
}
