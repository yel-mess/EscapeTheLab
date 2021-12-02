using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;
    public GameObject playerPrefab;
    public GameObject player;
    public GameObject inventory;
    public GameObject inventoryPrefab;
    //public string sceneName;
    void Awake()
    {
        if(instance == null) {
            DontDestroyOnLoad(gameObject);
            instance = this;
            player = Instantiate(playerPrefab);
            DontDestroyOnLoad(player);
            inventory = Instantiate(inventoryPrefab);
            DontDestroyOnLoad(inventory);
        }
        else {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // if(SceneManager.GetActiveScene().name != sceneName{   
        // }
    }
}
