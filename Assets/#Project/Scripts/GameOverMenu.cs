using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public bool gameRestart;
    public void QuitGame(){ //quit button in start menu
        Application.Quit();
    }

    public void RestartGame(){ //retry button in gameover screen

        gameRestart = true;
        SceneManager.LoadScene("Cellule3");
        Debug.Log("before removing");
        LevelManager.instance.inventory.GetComponentInChildren<Inventory>().RemoveItem();
        Debug.Log("after removing");
        gameRestart = false;
        // playerController.leftClickPressed = false;
        // playerController.lastClickedPos.x = player.transform.position.x;
    }
    public void GoToMenu() // start menu in game over screen
    {
        SceneManager.LoadScene("StartMenu");
    }
}
