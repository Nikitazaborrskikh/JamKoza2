using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIAnimComics : MonoBehaviour
{
    [SerializeField] private float _timeAnimation;
    [SerializeField] private RectTransform _panelComicsOne;
    [SerializeField] private RectTransform _panelComicsTwo;
    [SerializeField] private RectTransform _panelComicsThree;
    [SerializeField] private GameObject _canvasComics;

    private Tween _tween;

    private void Start()
    {
        _panelComicsOne.sizeDelta = new Vector2(-500, 1080);
        _panelComicsOne.DOSizeDelta(new Vector2(1920, 1080), _timeAnimation);      
    }

    private void Update()
    {
        
    }

    public void OnOpenComicsTwo()
    {
        _panelComicsTwo.sizeDelta = new Vector2(1920, -500);
        _panelComicsTwo.DOSizeDelta(new Vector2(1920, 1080), _timeAnimation);
    }

    public void OnOpenComicsThree()
    {
        _panelComicsThree.sizeDelta = new Vector2(-500,1080);
        _panelComicsThree.DOSizeDelta(new Vector2(1920, 1080), _timeAnimation);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }
}
