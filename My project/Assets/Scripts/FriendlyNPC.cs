using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FriendlyNPC : MonoBehaviour
{
    private bool isPlayerInRange = false; // Игрок находится в зоне видимости

    [SerializeField] private GameObject _canvasPressF;
    [SerializeField] private GameObject _canvasDialoge;


    [SerializeField] private TMP_Text _WhatTask;
    [SerializeField] private TMP_Text _DescriptionTask;
    [SerializeField] private TMP_Text _TaskIndex;

    [SerializeField] private int _indexNPC;

    private readonly string _WhatTaskNon = " ";
    private readonly string _DescriptionTaskNon = " ";
    private readonly string _TaskIndexNon = " ";

    private GiveTask _giveTask;

    public FriendlyNPC(GiveTask giveTask)
    {
        _giveTask = giveTask;
    }

    private void Start()
    {
        _canvasPressF.SetActive(false);
        _canvasDialoge.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Проверяем, находится ли в зоне видимости NPC игрок
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true; // Игрок находится в зоне видимости

            _canvasPressF.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("F");
                _WhatTask.text = _WhatTaskNon;
                _DescriptionTask.text = _DescriptionTaskNon;
                _TaskIndex.text = _TaskIndexNon;
            }
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        //if (_giveTask.TaskList[1])
        //{

        //}

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("F");
            _WhatTask.text = _WhatTaskNon;
            _DescriptionTask.text = _DescriptionTaskNon;
            _TaskIndex.text = _TaskIndexNon;

            _canvasDialoge.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Проверяем, покинул ли игрок зону видимости NPC
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false; // Игрок не находится в зоне видимости
            _canvasPressF.SetActive(false);
        }
    }
}
