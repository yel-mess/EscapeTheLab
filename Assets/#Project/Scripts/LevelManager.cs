using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;
    public GameObject playerPrefab;
    public GameObject player;
    public GameObject inventory;
    public GameObject inventoryPrefab;

    void Awake()
    {
        if(instance == null) {
            DontDestroyOnLoad(gameObject);
            instance = this;
            player = Instantiate(playerPrefab);
            inventory = Instantiate(inventoryPrefab);
            DontDestroyOnLoad(player);
            DontDestroyOnLoad(inventory);
        }
        else {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
