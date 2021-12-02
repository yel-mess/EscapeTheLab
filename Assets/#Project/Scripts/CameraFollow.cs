using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public GameObject player;
    //public Transform followTarget;
    public GameObject target;
    public Vector3 offset;
    // [Range(1,10)]
    // public float smoothFactor;
    public float minValue = -10f;
    public float maxValue = 10f;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Follow();
    }
    void Follow(){
        Vector3 targetPosition = target.transform.position + offset;
        // Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor*Time.deltaTime);
        transform.position = targetPosition;
        //transform.position = new Vector3(Mathf.Clamp(target.transform.position.x, minValue, maxValue), target.transform.position.y, target.transform.position.z);
    }
}
