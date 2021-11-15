using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonDetection : MonoBehaviour
{
    public UnityEvent whenItemIsSelected;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(1)){
            whenItemIsSelected?.Invoke();
        }
    }
}
