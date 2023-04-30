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

    [SerializeField] private float _timeAnimation;

    [SerializeField] private GameObject _imageOn;
    [SerializeField] private GameObject _imageOff;

    public void OnOpenDeveloperWindow()
    {
        _windowDeveloper.sizeDelta = new Vector2(-500, Screen.height);
        _windowDeveloper.DOSizeDelta(new Vector2(Screen.width, Screen.height), _timeAnimation);
    }

    public void OnCloseDeveloperWindow()
    {
        _windowDeveloper.sizeDelta = new Vector2(Screen.width, Screen.height);
        _windowDeveloper.DOSizeDelta(new Vector2(-500, Screen.height), _timeAnimation);
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
        if (_imageOn == true) 
        {            
            _imageOn.SetActive(false);
            _imageOff.SetActive(true);
        }
        else if (_imageOff == true)
        {
            _imageOn.SetActive(true);
            _imageOff.SetActive(false);
        }
        
    }
}
