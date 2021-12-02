using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    public ItemData itemData;
    public GameObject playerPrefab;
    public ItemData requiredItem;
    public bool isOpen = false;
    public Animator transition;
    public float transitionTime = 1f;
    GameObject destroyedItem;
    ItemViewController itemViewController;
    void Start(){
        playerPrefab = GameObject.FindGameObjectWithTag("Player");
    }
    void OnMouseOver() {
        if(Input.GetMouseButtonUp(1)){
            CheckIfCorrect();
        }
        //s'il n y a pas d'item --> ouvre
        //si l'item correspond --> ouvre
        //si l'item ne correspond pas ou pas d'item --> ferme
    }
    public void CheckIfCorrect(){

        //porte fermée, infranchissable
        if(!isOpen && requiredItem == null){
            Debug.Log("Door is locked");
        }
        //porte fermée, peut s'ouvrir grâce à un objet
        else if (!isOpen && requiredItem != null){
            
            if(ItemClicked.lastSelectedItem != null && requiredItem == ItemClicked.lastSelectedItem){
                //détruire l'objet
                //Debug.Log(itemViewController.itemGO);
                //Destroy(itemViewController.itemGO);
                isOpen = true;
                StartCoroutine(LoadLevel(sceneName));
            }
        }
        //porte ouverte
        else {
            //SceneManager.LoadScene(sceneName); // replace with coroutine
            StartCoroutine(LoadLevel(sceneName));
        }
    }
    IEnumerator LoadLevel(string scene){
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(scene);
    }
}
