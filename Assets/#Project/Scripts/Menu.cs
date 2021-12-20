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
    
    public void GoBack(){ // "Back" in the credits, start menu
        //SceneManager.LoadScene("StartMenu");
        startCanva.SetActive(true);
        creditCanva.SetActive(false);
        controlCanva.SetActive(false);
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
