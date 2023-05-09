using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbaloDoctora : MonoBehaviour
{
    private Transform _NPC;
    public Transform MinimapCam;
    public GameObject _miniMapMarker;
    public float MinimapSize;
    
    void Start()
    {
        _NPC = GetComponent<Transform>();
    }

    
    void Update()
    {
        _miniMapMarker.transform.position = _NPC.transform.position;
    }
    private void LateUpdate()
    {
        Vector2 centerPosition = MinimapCam.transform.position;
        centerPosition.y -= 0.5f;
        float Distance = Vector2.Distance(new Vector2(_miniMapMarker.transform.position.x , _miniMapMarker.transform.position.y), centerPosition);
        if (Distance > MinimapSize)
        {
            
            Vector2 fromOriginToObject = new Vector2(_miniMapMarker.transform.position.x , _miniMapMarker.transform.position.y) - centerPosition;
            

            
            fromOriginToObject *= MinimapSize / Distance;

            
            _miniMapMarker.transform.position = centerPosition + fromOriginToObject;
        }
    }
}
