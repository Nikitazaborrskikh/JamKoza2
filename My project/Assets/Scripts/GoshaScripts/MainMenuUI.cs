using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.GlobalIllumination;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private RectTransform _windowDeveloper;
    [SerializeField] private RectTransform _NamePanel;
    [SerializeField] private RectTransform _TutorialPanel;

    [SerializeField] private float _timeAnimation;

    [SerializeField] private GameObject _imageOn;
    [SerializeField] private GameObject _imageOff;

    public void OnOpenDeveloperWindow()
    {
        _windowDeveloper.sizeDelta = new Vector2(-500, 1080);
        _windowDeveloper.DOSizeDelta(new Vector2(1920, 1080), _timeAnimation);
    }

    public void OnCloseDeveloperWindow()
    {
        _windowDeveloper.sizeDelta = new Vector2(1920, 1080);
        _windowDeveloper.DOSizeDelta(new Vector2(-500, 1080), _timeAnimation);
    }

    public void OnOpenTutorialPanel()
    {
        _TutorialPanel.sizeDelta = new Vector2(1920, -500);
        _TutorialPanel.DOSizeDelta(new Vector2(1920, 1080), _timeAnimation);
    }

    public void OnCloseTutorialPanel()
    {
        _TutorialPanel.sizeDelta = new Vector2(1920, 1080);
        _TutorialPanel.DOSizeDelta(new Vector2(1920, -500), _timeAnimation);
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

    public void SwapMusic()
    {
        _imageOff.SetActive(true);
        _imageOn.SetActive(false);
    }

    public void SwapMusic1()
    {
        _imageOff.SetActive(false);
        _imageOn.SetActive(true);
    }
}
