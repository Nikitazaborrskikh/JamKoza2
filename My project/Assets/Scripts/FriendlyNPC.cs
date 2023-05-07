using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FriendlyNPC : MonoBehaviour
{
    private bool isPlayerInRange = false; 

    [SerializeField] private GameObject _canvasPressF;
     public GameObject _miniMapMarker;
     private Transform NPC;
     public Transform MinimapCam;
     public float MinimapSize;
     
    [SerializeField] private TMP_Text _WhatTask;
    [SerializeField] private TMP_Text _DescriptionTask;
    [SerializeField] private TMP_Text _TaskIndex;
    
    
   
    [SerializeField] private int _TaskIndexInt;
   [HideInInspector] public bool _isInteractable;
    public string _indexNPC;
    public string _indexNPC1;
    

    private readonly string _WhatTaskNon = " ";
    private readonly string _DescriptionTaskNon = " ";
    public readonly string _TaskIndexNon = " ";

    [SerializeField]private GiveTask _giveTask;
    [SerializeField] private DialogeManager _dialoge;
    
    

    public FriendlyNPC(GiveTask giveTask)
    {
        _giveTask = giveTask;
    }

    private void Start()
    {
        NPC = GetComponent<Transform>();
        _canvasPressF.SetActive(false);
        
       _miniMapMarker.SetActive(false);
       
    }

    private void Update()
    {
        _miniMapMarker.transform.position = NPC.transform.position;
        
        
        if (_indexNPC == _TaskIndex.text || _indexNPC1 == _TaskIndex.text)
        {
            _miniMapMarker.SetActive(true);
        }

        
        
             if (Input.GetKeyDown(KeyCode.F) && _isInteractable)
             {
                 if (!_dialoge.dialogActive)
                 {
                     QuestCompleted(); 
                 }
                      
             }
        
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

    void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.CompareTag("Player"))
        {
        
            if (_indexNPC == _TaskIndex.text || _indexNPC1 == _TaskIndex.text)
            {
                
                _isInteractable = true;
                isPlayerInRange = true;
                _canvasPressF.SetActive(true);

            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _isInteractable = false;
            _canvasPressF.SetActive(false);
            
        }
       
    }

    

    public void QuestCompleted()
    {
        
        _canvasPressF.SetActive(false);
        _WhatTask.text = _WhatTaskNon;
        _DescriptionTask.text = _DescriptionTaskNon;
        _TaskIndex.text = _TaskIndexNon;
       
        _giveTask._taskIndexInt = 0;
        _miniMapMarker.SetActive(false);
        
        ScoreAdd.AddScore();
        _isInteractable = false;
        _dialoge.dialogActive = false;
        

    }

    




}
