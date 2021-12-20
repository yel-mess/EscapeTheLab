using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    //TypeWriterEffect typeWriterEffect;
    public TMP_Text popUpText;
    public void Start()
    {
        //typeWriterEffect = GetComponent<TypeWriterEffect>();
    }
    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        animator.SetTrigger("Open");
    }
    public void ClosePopUp()
    {
        animator.SetTrigger("Close");
    }
}
