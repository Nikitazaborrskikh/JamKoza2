using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FriendlyNPC : MonoBehaviour
{
    private bool isPlayerInRange = false; // Игрок находится в зоне видимости

    [SerializeField] private GameObject _canvasPressF;
    [SerializeField] private GameObject _canvasDialoge;
     

    [SerializeField] private TMP_Text _WhatTask;
    [SerializeField] private TMP_Text _DescriptionTask;
    [SerializeField] private TMP_Text _TaskIndex;

    public string _indexNPC;
    public string _indexNPC1;

    private readonly string _WhatTaskNon = " ";
    private readonly string _DescriptionTaskNon = " ";
    private readonly string _TaskIndexNon = " ";

    private GiveTask _giveTask;

    public FriendlyNPC(GiveTask giveTask)
    {
        _giveTask = giveTask;
    }

    private void Start()
    {
        _canvasPressF.SetActive(false);
        _canvasDialoge.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            if (_indexNPC == _TaskIndex.text || _indexNPC1 == _TaskIndex.text)
            {
                isPlayerInRange = true;
                _canvasPressF.SetActive(true);
            }
            
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        
        if (_indexNPC == _TaskIndex.text|| _indexNPC1 == _TaskIndex.text)
        {
            _canvasPressF.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("F");
                _WhatTask.text = _WhatTaskNon;
                _DescriptionTask.text = _DescriptionTaskNon;
                _TaskIndex.text = _TaskIndexNon;
                _canvasDialoge.SetActive(false);
                _canvasPressF.SetActive(false);            
            }
        }
       
    }

   

    // void OnTriggerExit2D(Collider2D other)
    // {
    //     // Проверяем, покинул ли игрок зону видимости NPC
    //     if (other.CompareTag("Player"))
    //     {
    //         isPlayerInRange = false; // Игрок не находится в зоне видимости
    //         _canvasPressF.SetActive(false);
    //     }
    // }
}
