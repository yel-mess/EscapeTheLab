using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText;
    //string triggerName = "Open";
    //AnimatorClipInfo[] currentClipInfo;
    //bool popUpIsActive = false;

    public void Start()
    {
        //animator = GetComponent<Animator>();
        //currentClipInfo = animator.GetCurrentAnimatorClipInfo(0);
    }

    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        //popUpIsActive = true;
        animator.SetTrigger("Open");
        //Debug.Log("Open");
        //clipName = animator.GetCurrentAnimatorClipInfo
    }
    // public void OnMouseOver()
    // {
    //     if(Input.GetMouseButtonUp(1) && popUpIsActive)
    //     {
    //         popUpIsActive = false;
    //         animator.SetTrigger("Close");
    //     }
    // }
}
