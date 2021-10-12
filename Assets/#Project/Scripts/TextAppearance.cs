using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppearance : MonoBehaviour
{
    public Text text;
    public GameObject DoorCanva;

    void Start()
    {
        DoorCanva.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        OnMouseOver();
    }
    void OnMouseOver() {
        if(Input.GetMouseButtonUp(1)) {
            DoorCanva.SetActive(true);
        }
    }
}
