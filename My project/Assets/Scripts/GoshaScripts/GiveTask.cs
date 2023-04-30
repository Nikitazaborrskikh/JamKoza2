using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

public class GiveTask : MonoBehaviour
{
    public List<ScriptableObject> TaskList = new();
   
    [SerializeField] TMP_Text _WhatTask;
    [SerializeField] TMP_Text _DescriptionTask;
    [SerializeField] TMP_Text _TaskIndex;

    //private TaskData _taskData;

    private void Awake()
    {
        TaskList[0] = Resources.Load<TaskData>("TaskOne");
        TaskList[1] = Resources.Load<TaskData>("TaskTwo");       
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
        _WhatTask.text = TaskList[0].ToString(); 
        //_DescriptionTask.text = _taskData.DescriptionTask;
        //_TaskIndex.text = _taskData.TaskIndex;
    }
}
