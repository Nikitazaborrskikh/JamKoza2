using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    [SerializeField] private int _numberScene;
   public void Swap()
    {
        SceneManager.LoadScene(_numberScene);
    }
}
