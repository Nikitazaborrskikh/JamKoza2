using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Score
{
    public string Name;
    public float score;

    public Score(string name, float score)
    {
        Name = name;
        this.score = score;
    }
}
