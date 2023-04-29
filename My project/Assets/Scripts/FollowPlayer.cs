using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; 
    public float smoothing = 5f; 
    public Vector3 offset = new Vector3(0f, 1f, -10f); 

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>(); 
    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset; 

        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime); 
    }
}
