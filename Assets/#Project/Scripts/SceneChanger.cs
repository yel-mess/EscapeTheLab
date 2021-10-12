using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //[HideInInspector]
    //public bool rightClickPressed = false;

    //public string scene;
    //public Sprite door;

    void Start()
    {
        
    }


    void Update()
    {
        // if (rightClickPressed) {
        //     Debug.Log("Update works");
        //     //Change();
        // }
        //rightClickPressed = false;
        if(Input.GetMouseButtonUp(1)) {
            Debug.Log("Right click detected");
            SceneManager.LoadScene("Couloir A");
        }
    }
    // public void Interact(InputAction.CallbackContext context) {
    //     if (context.performed) {
    //         rightClickPressed = true;
    //         Debug.Log("Interact works");
    //     }
    // }
    // private void Change() {
    //     Debug.Log("Change works");
    //     SceneManager.LoadScene("Couloir C");
    // }
}
