using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //public string sceneName;
    //PlayerController playerController;
    //GameObject player;
    public GameObject startCanva;
    public GameObject creditCanva;
    public GameObject controlCanva;
    public bool gameRestart;

    void Awake()
    {
        creditCanva.SetActive(false);
    }
    void Start()
    {
        
    }
    public void PlayGame(){ //start button in start menu
        SceneManager.LoadScene("Cellule3");
        //SceneManager.LoadScene(SceneManagement.GetActiveScene().buildIndex+1)
    }
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
    public void GoBack(){ // "Back" in the credits, start menu
        //SceneManager.LoadScene("StartMenu");
        startCanva.SetActive(true);
        creditCanva.SetActive(false);
        controlCanva.SetActive(false);
    }

    public void GoToMenu() // start menu in game over screen
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Cedits() // credits buttin in start menu
    {
        creditCanva.SetActive(true);
        startCanva.SetActive(false);
        //SceneManager.LoadScene("Credits");
    }

    public void Controls()
    {
        controlCanva.SetActive(true);
        startCanva.SetActive(false);
    }
}
