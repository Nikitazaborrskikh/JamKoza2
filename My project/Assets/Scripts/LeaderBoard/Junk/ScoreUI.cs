using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public RowUI _rowUI;
    public ScoreManager _scoreManager;

    private SaveName _saveName;
    private string _savePath = "fgfg";
    private float _saveIndex = 1488;

    public ScoreUI(SaveName saveName)
    {
        _saveName = saveName;
    }

    private void Start()
    {

        Debug.Log(_saveName.NameSave);
        //_scoreManager.AddScore(new Score(_saveName.NameSave, _saveIndex));
        _scoreManager.AddScore(new Score("boba", 1337));


        var scores = _scoreManager.GetHighScore().ToArray();
        
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(_rowUI, transform).GetComponent<RowUI>();
            row.Rank.text = (i + 1).ToString();
            row.Name.text = scores[i].Name;
            row.Score.text = scores[i].score.ToString();
        }
    }
}
