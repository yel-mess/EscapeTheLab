using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicked : MonoBehaviour
{
    public static bool clicked = false;

    public void OnSelect()
    {
        clicked = true;
    }
}
