using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonEffect : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private Color _alphaChange;

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}
