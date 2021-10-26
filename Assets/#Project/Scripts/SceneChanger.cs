using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //public bool isOpen = false;
    public string sceneName;
    //public GameObject door;
    void Start() {
        // door = GetComponent<GameObject>();
    }
    void Update()
    {
        // if(Input.GetMouseButtonUp(1)) {
        //     Debug.Log("Right Click");
        //     RaycastHit hit;
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //     if(Physics.Raycast(ray, out hit, 100.0f)) {
        //         if(hit.collider.gameObject.tag == "Door") {
        //             SceneManager.LoadScene(sceneName);
        //         }
        //     }
        // }
    }
    void OnMouseOver() {
        if(Input.GetMouseButtonUp(1)) {
            SceneManager.LoadScene(sceneName);
        }
    }
}
