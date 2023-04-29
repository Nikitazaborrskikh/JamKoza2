using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
        _panelComicsOne.sizeDelta = new Vector2(-500, _panelComicsOne.sizeDelta.y);
        _panelComicsOne.DOSizeDelta(new Vector2(Screen.width, _panelComicsOne.sizeDelta.y), _timeAnimation);      
    }

    private void Update()
    {
        
    }

    public void OnOpenComicsTwo()
    {
        _panelComicsTwo.sizeDelta = new Vector2(-500, _panelComicsTwo.sizeDelta.y);
        _panelComicsTwo.DOSizeDelta(new Vector2(Screen.width, _panelComicsTwo.sizeDelta.y), _timeAnimation);
    }

    public void OnOpenComicsThree()
    {
        _panelComicsThree.sizeDelta = new Vector2(-500, _panelComicsThree.sizeDelta.y);
        _panelComicsThree.DOSizeDelta(new Vector2(Screen.width, _panelComicsThree.sizeDelta.y), _timeAnimation);
    }
}
