using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }
}
