using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class TypeWriterEffect : MonoBehaviour
{
    public TextAsset userText;
    public float delay = 0.1f;
    string fullText;
    TMP_Text textMeshPro;
    public bool completed = false;
    //public GameObject nextButton;

    void Awake()
    {
        textMeshPro = GetComponent<TMP_Text>();
        fullText = userText.text;
        textMeshPro.text = fullText;
        textMeshPro.enableWordWrapping = true;
        textMeshPro.alignment = TextAlignmentOptions.Center;
    }
    void Start()
    {
        StartCoroutine("RevealText");
    }

    public IEnumerator RevealText()
    {
        textMeshPro.ForceMeshUpdate();

        int totalVisibleCharacters = textMeshPro.textInfo.characterCount;
        int counter = 0; //nbr de caractère
        int visibleCount = 0;

        for(int i = 0; i < fullText.Length; i++)
        {
            visibleCount = counter % (totalVisibleCharacters + 1);

            textMeshPro.maxVisibleCharacters = visibleCount;

            if(visibleCount >= totalVisibleCharacters)
            {
                textMeshPro.text = fullText;
                completed = true;
                StopCoroutine("RevealText");
            }
            //nextButton.SetActive(true);

            counter += 1;

            yield return new WaitForSeconds(delay);
        }

    }
}
