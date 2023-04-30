using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private RectTransform _panelComicsOne;
    [SerializeField] private RectTransform _NamePanel;

    [SerializeField] private float _timeAnimation;

    public void OnOpenDeveloperWindow()
    {
        _panelComicsOne.sizeDelta = new Vector2(-500, _panelComicsOne.sizeDelta.y);
        _panelComicsOne.DOSizeDelta(new Vector2(Screen.width, _panelComicsOne.sizeDelta.y), _timeAnimation);
    }

    public void OnCloseDeveloperWindow()
    {
        _panelComicsOne.sizeDelta = new Vector2(Screen.width, _panelComicsOne.sizeDelta.y);
        _panelComicsOne.DOSizeDelta(new Vector2(-500, _panelComicsOne.sizeDelta.y), _timeAnimation);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void HideNamePanel()
    {
        _NamePanel.sizeDelta = new Vector2(Screen.width, _NamePanel.sizeDelta.y);
        _NamePanel.DOSizeDelta(new Vector2(-1000, _NamePanel.sizeDelta.y), _timeAnimation);
    }
}
