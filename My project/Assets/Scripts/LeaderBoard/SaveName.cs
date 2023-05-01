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
    private int _scorePlayer = 0;
    private string _name;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        highscoreTable = new HighscoreTable();
    }

    public void OnSaveName()
    {

        highscoreTable.AddHighscoreEntry(_scorePlayer, NamePlayer.text);
        _panelClose.SetActive(false);
    }
}
