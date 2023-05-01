using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;


public class DialogeManager : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;

    public string[] dialogLines;
    public string[] dialogLines1;
    public int currentLine;
    [SerializeField] GiveTask _giveTask;
    private int randomIndex;

    
    public GameObject player; 

    private bool dialogActive; 
    
    void Start()
    {
        dialogBox.SetActive(false); 
        randomIndex = Random.Range(-10, 10);
        
    }

    void Update()
    {
        
        if (dialogActive)
        {
            
            if(randomIndex <= 0)
            {
                dialogText.text = dialogLines[currentLine];
            }
            if (randomIndex > 0)
            {
                dialogText.text = dialogLines1[currentLine];
            }
           

            
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
        
        
           
            if (Input.GetKeyDown(KeyCode.F))
            {
                
                Debug.Log(randomIndex);
                if(randomIndex <= 0)
                {
                    ShowDialog();
                }
                if(randomIndex >= 0)
                {
                    ShowDialog1();
                }
                
                
                
            }
            
        
        
    }
}
