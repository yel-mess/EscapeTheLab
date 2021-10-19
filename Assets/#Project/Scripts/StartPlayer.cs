using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    void Start()
    {
        GameObject.FindObjectOfType<LevelManager>().player.transform.position = transform.position;

        // LevelManager levelManager = LevelManager.instance;
        // GameObject player = levelManager.player;
        // player.transform.position = transform.position;
    }
}
