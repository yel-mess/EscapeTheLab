using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;
    public GameObject playerPrefab;
    public GameObject player;

    void Awake()
    {
        if(instance == null) {
            DontDestroyOnLoad(gameObject);
            instance = this;
            player = Instantiate(playerPrefab);
            DontDestroyOnLoad(player);
        }
        else {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
