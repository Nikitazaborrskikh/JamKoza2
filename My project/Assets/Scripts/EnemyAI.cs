using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    
    public float moveSpeed = 5f; 
    public float aggroRange = 5f; 
    
    private Transform target; 
    private bool isChasing = false;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    void Update()
    {
       
        float distanceToTarget = Vector2.Distance(transform.position, target.position);
        
        
        if (distanceToTarget < aggroRange)
        {
            isChasing = true; 
        }
        else
        {
            isChasing = false; 
        }
        
        if (isChasing)
        {
            
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }

        if (distanceToTarget <= 1f)
        {
            
            SceneManager.LoadScene(6);
        }
    }
}

