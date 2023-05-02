using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FriendlyNPC : MonoBehaviour
{
    private bool isPlayerInRange = false; // Игрок находится в зоне видимости

    [SerializeField] private GameObject _canvasPressF;
    [SerializeField] private GameObject _canvasDialoge;
    [SerializeField] private GameObject _miniMapMarker;

    [SerializeField] private TMP_Text _WhatTask;
    [SerializeField] private TMP_Text _DescriptionTask;
    [SerializeField] private TMP_Text _TaskIndex;
   // [SerializeField] private Image _imageTask;
    //[SerializeField] private Image _imageTask2;
    [SerializeField] private int _TaskIndexInt;
    private bool _isInteractable;
    public string _indexNPC;
    public string _indexNPC1;

    private readonly string _WhatTaskNon = " ";
    private readonly string _DescriptionTaskNon = " ";
    public readonly string _TaskIndexNon = " ";

    [SerializeField]private GiveTask _giveTask;
    
    

    public FriendlyNPC(GiveTask giveTask)
    {
        _giveTask = giveTask;
    }

    private void Start()
    {
        _canvasPressF.SetActive(false);
        _canvasDialoge.SetActive(false);
       _miniMapMarker.SetActive(false);
    }

    private void Update()
    {
        
        if (_indexNPC == _TaskIndex.text || _indexNPC1 == _TaskIndex.text)
        {
            _miniMapMarker.SetActive(true);
                
        }

        if (_isInteractable)
        {
            if (Input.GetKeyDown(KeyCode.F))
            { 
                Debug.Log("F");
                QuestCompleted();       
            }
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
        }
       
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        
        if (_indexNPC == _TaskIndex.text|| _indexNPC1 == _TaskIndex.text)
        {
            _canvasPressF.SetActive(true);
           Debug.Log("1111");
           _isInteractable = true;

           
        }
       
    }

    public void QuestCompleted()
    {
        _WhatTask.text = _WhatTaskNon;
        _DescriptionTask.text = _DescriptionTaskNon;
        _TaskIndex.text = _TaskIndexNon;
        //_imageTask = _imageTask2;
        _giveTask._taskIndexInt = 0;
        _miniMapMarker.SetActive(false);
        _canvasDialoge.SetActive(false);
        _canvasPressF.SetActive(false);
        ScoreAdd.AddScore();
        _isInteractable = false;
    }

    




}
