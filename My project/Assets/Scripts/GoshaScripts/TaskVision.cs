using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskVision : MonoBehaviour
{
    [SerializeField] TMP_Text _WhatTask;
    [SerializeField] TMP_Text _DescriptionTask;
    [SerializeField] TMP_Text _TaskIndex;

    private TaskData _taskData;
   

    private void Awake()
    {
        _taskData = Resources.Load<TaskData>("TaskOne");
       
    }
}
