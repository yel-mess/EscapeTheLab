using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;
    public GameObject inventory;
    public GameObject inventoryPrefab;
    public GameObject popUpCanva;
    void Awake()
    {
        if(instance == null) {
            DontDestroyOnLoad(gameObject);
            instance = this;
            inventory = Instantiate(inventoryPrefab);
            DontDestroyOnLoad(inventory);
            DontDestroyOnLoad(popUpCanva);
        }
        else {
            Destroy(gameObject);
        }
    }
}
