using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;


public class DialogeManager : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;

    public string[] dialogLines;
    public string[] dialogLines1;
    public int currentLine;
    [SerializeField] GiveTask _giveTask;
    private int randomIndex;
    [SerializeField] private GameObject[] _pictures;
    private int counter = 0;

    
    [SerializeField] private GameObject _player;
    [SerializeField] private FriendlyNPC _npc;
    private Rigidbody2D _playerRB;

   [HideInInspector] public bool dialogActive; 
    
    void Start()
    {
        dialogBox.SetActive(false); 
        randomIndex = Random.Range(-10, 10);
        dialogActive = false;
         _playerRB = _player.GetComponent<Rigidbody2D>() ;

    }

    void Update()
    {
        
        
        if (dialogActive)
        {
            _playerRB.constraints = RigidbodyConstraints2D.FreezePosition;
            _pictures[counter].SetActive(true);

            if(_giveTask._taskIndexInt % 2 == 0)
            {
                ShowDialog();
            }
            if (_giveTask._taskIndexInt % 2 != 0)
            {
                ShowDialog1();
            }
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentLine++;
                _pictures[counter].SetActive(false);
                _pictures[counter++].SetActive(false);
                
                if (currentLine >= dialogLines.Length || currentLine >= dialogLines1.Length)
                {
                    
                    _playerRB.constraints = RigidbodyConstraints2D.None;
                    _playerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
                    
                    counter = 0;
                    dialogBox.SetActive(false);
                    dialogActive = false;
                    currentLine = 0;
                   
                    
                }
            }
        }
    }

    public void ShowDialog()
    {
        

        
        dialogBox.SetActive(true);
        dialogText.text = dialogLines[currentLine];
    }
    public void ShowDialog1()
    {
        

        
        dialogBox.SetActive(true);
        dialogText.text = dialogLines1[currentLine];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
                if (_npc._isInteractable)
                {
                    Debug.Log(_npc._isInteractable);
                    dialogActive = true;
                }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        dialogActive = false;
    }
}
