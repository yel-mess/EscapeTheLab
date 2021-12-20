using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    public ItemData requiredItem;
    public bool isOpen = false;
    public Animator transition;
    public float transitionTime = 1f;
    public string noItemPopUp;
    public string wrongItemPopUp;
    public string doorClosedPopUp;

    void OnMouseOver() {
        if(Input.GetMouseButtonUp(1)){
            CheckIfCorrect();
        }
    }
    public void CheckIfCorrect(){

        //porte fermée, infranchissable
        if(!isOpen && requiredItem == null){
            PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
            pop.PopUp(doorClosedPopUp);
        }

        //porte fermée, peut s'ouvrir grâce à un objet
        else if (!isOpen && requiredItem != null){
            
            //the correct item is selected
            if(ItemClicked.lastSelectedItem != null && requiredItem == ItemClicked.lastSelectedItem){
                //détruire l'objet
                //jouer un son
                isOpen = true;
                StartCoroutine(LoadLevel(sceneName));
            }

            //wrong item is selected
            else if(ItemClicked.lastSelectedItem != null && requiredItem != ItemClicked.lastSelectedItem)
            {
                //enclencher un son
                PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
                pop.PopUp(wrongItemPopUp);
            }

            //no item is selected
            else
            {
                //enclencher un son
                PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
                pop.PopUp(noItemPopUp);
            }
        }

        //porte ouverte
        else {
            //SceneManager.LoadScene(sceneName); // replace with coroutine
            StartCoroutine(LoadLevel(sceneName));
        }
    }
    IEnumerator LoadLevel(string scene){
        //enclencher un son
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(scene);
    }
}
