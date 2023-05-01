using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreAdd : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoretext;
    public int score = 0;



    public void AddScore()
    {
        score += 100;
        _scoretext.text = $"Score:{score}";
    }
}
