using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    //bool popUpIsActive = false;
    //TypeWriterEffect typeWriterEffect;
    public void Start()
    {
        //typeWriterEffect = popUpBox.GetComponent<TypeWriterEffect>();
        //print(typeWriterEffect.completed);
    }
    public void Update()
    {
        // if(Input.GetMouseButtonUp(1))
        // {
        //     animator.SetTrigger("Close");
        // }
    } 
    public void PopUp()
    {
        popUpBox.SetActive(true);
        animator.SetTrigger("Open");
    }
    
    // IEnumerator ClosePopUp()
    // {
    //     //attendre que le texte s'affiche en entier
        
    // }
    public void ClosePopUp()
    {
        animator.SetTrigger("Close");
    }
}
