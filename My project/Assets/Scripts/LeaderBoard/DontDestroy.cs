using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
