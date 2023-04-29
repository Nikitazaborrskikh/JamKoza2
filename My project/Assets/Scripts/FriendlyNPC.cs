using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyNPC : MonoBehaviour
{
    private bool isPlayerInRange = false; // Игрок находится в зоне видимости

    void Update()
    {
        // Проверяем, находится ли игрок в зоне видимости NPC
        if (isPlayerInRange)
        {
            // Реагируем на приближение игрока
            Debug.Log("Привет, Мой друг!");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Проверяем, находится ли в зоне видимости NPC игрок
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true; // Игрок находится в зоне видимости
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Проверяем, покинул ли игрок зону видимости NPC
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false; // Игрок не находится в зоне видимости
        }
    }
}
