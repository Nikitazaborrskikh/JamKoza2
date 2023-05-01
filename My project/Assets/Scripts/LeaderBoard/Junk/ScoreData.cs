using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class ScoreData
{
    public List<Score> Scores;

    public ScoreData()
    {
        Scores = new List<Score>();
    }
}
