using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

public class GiveTask : MonoBehaviour
{
    public List<TaskData> TaskList = new();
   
    [SerializeField] private TMP_Text _whatTask;
    [SerializeField] private TMP_Text _descriptionTask;
    [SerializeField] private TMP_Text _taskIndex;
    public int _taskIndexInt = 0;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Give a Task");
            SelectTask();
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
    }

    public int ReturnID()
    {
        Debug.Log("Aboba");
        return _taskIndexInt;
        
    }
}
