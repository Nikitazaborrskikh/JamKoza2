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
    public int currentLine; 

    public GameObject player; 

    private bool dialogActive; 

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

                
                if (currentLine >= dialogLines.Length)
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

    private void OnTriggerStay2D(Collider2D other)
    {
        
        
           
            if (Input.GetKey(KeyCode.F))
            {
                
                ShowDialog();
            }
            
        
        
    }
}
