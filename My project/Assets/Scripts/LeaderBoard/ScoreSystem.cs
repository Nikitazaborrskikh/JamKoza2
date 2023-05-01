using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;   

    private HighscoreTable highscoreTable;

    public void OnSaveScore()
    {
        highscoreTable.AddName(_scoreText.text);       
    }
}
