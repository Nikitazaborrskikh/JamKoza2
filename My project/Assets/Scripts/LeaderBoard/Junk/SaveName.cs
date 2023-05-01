using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveName : MonoBehaviour
{
    public TextMeshProUGUI NamePlayer;

    [HideInInspector] public string NameSave
    {
        get 
        {
            return NamePlayer.text;
        }
        set 
        {
            NamePlayer.text = value;
        }
    }
    public void OnSaveName()
    {
        DontDestroyOnLoad(this);
        NameSave = NamePlayer.text;
        Debug.Log(NameSave);
    }
}
