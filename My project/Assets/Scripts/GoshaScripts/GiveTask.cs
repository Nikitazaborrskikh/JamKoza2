using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

public class GiveTask : MonoBehaviour
{
    public List<ScriptableObject> TaskList = new();
   
    [SerializeField] private TMP_Text _whatTask;
    [SerializeField] private TMP_Text _descriptionTask;
    [SerializeField] private TMP_Text _taskIndex;

    private TaskData _taskData;

    private void Awake()
    {
        _taskData = Resources.Load<TaskData>("TaskOne");
        //TaskList[1] = Resources.Load<TaskData>("TaskTwo");       
    }

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

        _whatTask.text = _taskData.WhatTask;
        _descriptionTask.text = _taskData.DescriptionTask;
        _taskIndex.text = _taskData.TaskIndex;

    }
}
