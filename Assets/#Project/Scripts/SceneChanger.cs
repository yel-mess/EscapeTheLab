using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    public GameObject openText;
    void Start() {
        openText = GetComponent<GameObject>();
    }
    void Update()
    {
        Change();
    }
    public void Change() {
        if(Input.GetMouseButtonUp(1)) {
            SceneManager.LoadScene(sceneName);
        }
    }
}
