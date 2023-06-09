using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Linq;

public class HighscoreTable : MonoBehaviour
{
   

    private Transform _entryContainer;
    private Transform _entyTemplate;

    //private List<HighscoreEntry> _highscoreEntryList;
    private List<Transform> _highscoreEntryTransformList;

    private void Awake()
    {

        _entryContainer = transform.Find("ContentText");
        _entyTemplate = _entryContainer.Find("Template");

        _entyTemplate.gameObject.SetActive(false);

        //_highscoreEntryList = new List<HighscoreEntry>()
        //{
        //    new HighscoreEntry{ Score = 229, Name = "biba"}
        //};

        //AddHighscoreEntry(228, "Biba");
        //AddHighscoreEntry(339, "Boba");

        string jsonString = PlayerPrefs.GetString("highscoreTable");
       
        //Debug.Log(jsonString);
        if (jsonString != "")
        {
            Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

            for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
            {
                for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
                {
                    if (highscores.highscoreEntryList[j].Score > highscores.highscoreEntryList[i].Score)
                    {
                        HighscoreEntry entry = highscores.highscoreEntryList[i];
                        highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                        highscores.highscoreEntryList[j] = entry;
                    }
                }
            }

            _highscoreEntryTransformList = new List<Transform>();
            foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
            {
                CreateHighscoreEntryTransform(highscoreEntry, _entryContainer, _highscoreEntryTransformList);
            }
        }       
    }

    //private void OpenTable()
    //{
    //    _entryContainer = transform.Find("ContentText");
    //    _entyTemplate = _entryContainer.Find("Template");

    //    _entyTemplate.gameObject.SetActive(false);


    //    //AddHighscoreEntry(1337, "biba");      

    //    string jsonString = PlayerPrefs.GetString("highscoreTable");
    //    Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

    //    for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
    //    {
    //        for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
    //        {
    //            if (highscores.highscoreEntryList[j].Score > highscores.highscoreEntryList[i].Score)
    //            {
    //                HighscoreEntry entry = highscores.highscoreEntryList[i];
    //                highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
    //                highscores.highscoreEntryList[j] = entry;
    //            }
    //        }
    //    }


    //    _highscoreEntryTransformList = new List<Transform>();
    //    foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
    //    {
    //        CreateHighscoreEntryTransform(highscoreEntry, _entryContainer, _highscoreEntryTransformList);
    //    }
    //}

    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformsList)
    {
        float templateHeigh = 30f;

        Transform entryTransform = Instantiate(_entyTemplate, container);
        //RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        //entryRectTransform.anchoredPosition = new Vector2(0, -templateHeigh * transformsList.Count);
        entryTransform.gameObject.SetActive(true);


        int rank = transformsList.Count + 1;
        string rankString;
        switch (rank)
        {
            default:
                rankString = rank + "TH";
                break;

            case 1:
                rankString = "1ST";
                break;
            case 2:
                rankString = "2ND";
                break;
            case 3:
                rankString = "3RD";
                break;
        }
        entryTransform.Find("Rank").GetComponent<TMP_Text>().text = rankString;

        string Name = highscoreEntry.Name;
        entryTransform.Find("Name").GetComponent<TMP_Text>().text = Name;

        int score = highscoreEntry.Score;
        entryTransform.Find("Score").GetComponent<TMP_Text>().text = score.ToString();

        transformsList.Add(entryTransform);
    }

    public void AddHighscoreEntry(int score, string name)
    {
        HighscoreEntry highscoreEntry = new() { Score = score, Name = name };

        string jsonString = PlayerPrefs.GetString("highscoreTable");

        Highscores highscores = new Highscores();
        if (jsonString != "")
        {
            highscores = JsonUtility.FromJson<Highscores>(jsonString);
            
        }

        highscores.highscoreEntryList.Add(highscoreEntry);
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }

    private class Highscores
    {
        public List<HighscoreEntry> highscoreEntryList = new List<HighscoreEntry>();
    }



    [Serializable]
    private class HighscoreEntry
    {
        public int Score;
        public string Name;
    }
}
