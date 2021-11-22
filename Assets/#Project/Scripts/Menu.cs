using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string sceneName;
    public void PlayGame(){
        SceneManager.LoadScene("Cellule3");
        //SceneManager.LoadScene(SceneManagement.GetActiveScene().buildIndex+1)
    }
    public void QuitGame(){
        Application.Quit();
    }
    public void RestartGame(){

    }
}
