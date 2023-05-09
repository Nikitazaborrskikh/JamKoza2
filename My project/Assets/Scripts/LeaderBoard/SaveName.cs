using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveName : MonoBehaviour
{
    public TextMeshProUGUI NamePlayer;
    [SerializeField] private GameObject _panelClose;

    private HighscoreTable highscoreTable;
    
    private int _scorePlayer;
    private string _name;
    //[SerializeField] private ScoreAdd _scoreAdd;
    
    private void Awake()
    {
        
        highscoreTable = new HighscoreTable();
    }
     
    public void OnClosePanel()
    {
        //_name = NamePlayer.text;
        _panelClose.SetActive(false);
    }

    public void OnSaveName()
    {
        Debug.Log(NamePlayer.text);
        highscoreTable.AddHighscoreEntry(ScoreAdd.ScoreCount(), NamePlayer.text);    
        ScoreAdd.ResetScore();
    }
}
