using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //public string sceneName;
    //PlayerController playerController;
    //GameObject player;
    public bool gameRestart;

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        
    }
    public void PlayGame(){
        SceneManager.LoadScene("Cellule3");
        //SceneManager.LoadScene(SceneManagement.GetActiveScene().buildIndex+1)
    }
    public void QuitGame(){
        Application.Quit();
    }
    public void RestartGame(){

        gameRestart = true;
        SceneManager.LoadScene("Cellule3");
        Debug.Log("before removing");
        LevelManager.instance.inventory.GetComponentInChildren<Inventory>().RemoveItem();
        Debug.Log("after removing");
        gameRestart = false;
        // playerController.leftClickPressed = false;
        // playerController.lastClickedPos.x = player.transform.position.x;
    }
    public void GoToMenu(){
        SceneManager.LoadScene("StartMenu");
    }
    // void StopPlayerMovement()
    // {
        
    // }
}
