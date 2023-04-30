using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class DialogeManager : MonoBehaviour
{
    public GameObject dialogBox; // Ссылка на диалоговое окно
    public TextMeshProUGUI dialogText; // Ссылка на текст в диалоговом окне

    public string[] dialogLines; // Реплики NPC и персонажа
    public int currentLine; // Текущая реплика

    public GameObject player; // Ссылка на персонажа

    private bool dialogActive; // Отображается ли диалоговое окно

    void Start()
    {
        dialogBox.SetActive(false); // Скрываем диалоговое окно при старте игры
    }

    void Update()
    {
        // Проверяем, активирован ли диалоговое окно
        if (dialogActive)
        {
            // Показываем текущую реплику
            dialogText.text = dialogLines[currentLine];

            // Если нажат пробел, переходим к следующей реплике
            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentLine++;

                // Закрываем диалоговое окно, если это была последняя реплика
                if (currentLine >= dialogLines.Length)
                {
                    dialogBox.SetActive(false);
                    dialogActive = false;
                    currentLine = 0;

                    // Разрешаем персонажу двигаться после окончания диалога
                    //player.GetComponent<PlayerController>().canMove = true;
                }
            }
        }
    }

    public void ShowDialog()
    {
        dialogActive = true; // Отображаем диалоговое окно
        currentLine = 0; // Устанавливаем текущую реплику в начало

        // Блокируем персонажа во время диалога
        //player.GetComponent<PlayerController>().canMove = false;

        // Показываем реплику NPC
        dialogBox.SetActive(true);
        dialogText.text = dialogLines[currentLine];
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
        
            Debug.Log("Biba");
            if (Input.GetKey(KeyCode.F))
            {
                Debug.Log("Boba");
                ShowDialog();
            }
            
        
        
    }
}
