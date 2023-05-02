using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public  class GiveTask : MonoBehaviour
{
    public List<TaskData> TaskList = new();
    private FriendlyNPC _friendlyNpc;
    [SerializeField] private TMP_Text _whatTask;
    [SerializeField] private TMP_Text _descriptionTask;
    [SerializeField] private TMP_Text _taskIndex;
    //[SerializeField] private Image _imageTask;
     public int _taskIndexInt = 0;
     
     

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(_taskIndexInt == 0)
            {
              Debug.Log("Give a Task"); 
              SelectTask();
            }
        
            
        }
            
    }

    

    public void SelectTask()
    {
        
        int randomIndex = Random.Range(0, TaskList.Count);
        
        TaskData randomSO = TaskList[randomIndex];
        
        _whatTask.text = randomSO.WhatTask;
        _descriptionTask.text = randomSO.DescriptionTask;
        _taskIndex.text = randomSO.TaskIndex;
        _taskIndexInt = randomSO.TaskIndexInt;
       // _imageTask = randomSO.ImageTask;
    }

    




}
