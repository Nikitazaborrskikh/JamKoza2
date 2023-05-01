using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private ScoreData _scoreData;

    private void Awake()
    {
        var json = PlayerPrefs.GetString("score", "{}");
        _scoreData = JsonUtility.FromJson<ScoreData>(json);
    }

    public IEnumerable<Score> GetHighScore()
    {
        return _scoreData.Scores.OrderByDescending( x => x.score);
    }

    public void AddScore(Score score)
    {
        _scoreData.Scores.Add(score);
    }

    private void OnDestroy()
    {
        SaveScore();
    }

    public void SaveScore()
    {
        var json = JsonUtility.ToJson(_scoreData);
        PlayerPrefs.SetString("score", json);
    }
}
