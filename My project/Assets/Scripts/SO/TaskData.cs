using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = " New Task", menuName = "Task", order = 51)]
public class TaskData : ScriptableObject
{
    public string WhatTask;
    public string DescriptionTask;
    public string TaskIndex;
    public int TaskIndexInt;
    //public Image ImageTask;

}