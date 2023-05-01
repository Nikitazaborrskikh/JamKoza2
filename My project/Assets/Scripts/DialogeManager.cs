using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class DialogeManager : MonoBehaviour
{
    public GameObject dialogBox; 
    public TextMeshProUGUI dialogText; 
    
    public string[] dialogLines;
    public string[] dialogLines1;
    public int currentLine; 
    private GiveTask _giveTask;
    public GameObject player; 

    private bool dialogActive; 
    public DialogeManager(GiveTask giveTask)
    {
        _giveTask = giveTask;
    }
    void Start()
    {
        dialogBox.SetActive(false); 
    }

    void Update()
    {
        
        if (dialogActive)
        {
            
            dialogText.text = dialogLines[currentLine];

            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentLine++;

                
                if (currentLine >= dialogLines.Length || currentLine >= dialogLines1.Length)
                {
                    dialogBox.SetActive(false);
                    dialogActive = false;
                    currentLine = 0;

                    
                }
            }
        }
    }

    public void ShowDialog()
    {
        dialogActive = true; 

        
        dialogBox.SetActive(true);
        dialogText.text = dialogLines[currentLine];
    }
    public void ShowDialog1()
    {
        dialogActive = true; 

        
        dialogBox.SetActive(true);
        dialogText.text = dialogLines1[currentLine];
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
        
           
            if (Input.GetKey(KeyCode.F))
            {
                if(_giveTask._taskIndexInt % 2 == 0)
                {
                    ShowDialog();
                }
                else
                {
                    ShowDialog1(); 
                }
            }
            
        
        
    }
}
