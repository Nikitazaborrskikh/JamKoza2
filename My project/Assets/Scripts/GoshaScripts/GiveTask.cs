using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GiveTask : MonoBehaviour
{
    public List<ScriptableObject> TaskList = new();

    [SerializeField] TMP_Text _WhatTask;
    [SerializeField] TMP_Text _DescriptionTask;
    [SerializeField] TMP_Text _TaskIndex;

    private TaskData _taskData;

    private void Awake()
    {
        _taskData = Resources.Load<TaskData>("TaskOne");
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
        _WhatTask.text = _taskData.WhatTask;
        _DescriptionTask.text = _taskData.DescriptionTask;
        _TaskIndex.text = _taskData.TaskIndex;
    }
}
