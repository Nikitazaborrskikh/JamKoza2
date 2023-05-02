using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; 
    private Rigidbody2D playerRigidbody2D; 
    private Vector2 direction;
    [SerializeField] private SpriteRenderer _sprite;
    

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>(); 
        
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); 
        float y = Input.GetAxisRaw("Vertical"); 
        direction = new Vector2(x, y).normalized; 

       
    }

    void FixedUpdate()
    {
        playerRigidbody2D.MovePosition(playerRigidbody2D.position + direction * speed * Time.fixedDeltaTime);
        if (direction.x < 0)
        {
            _sprite.flipX = true;
        }
        if (direction.x >= 0)
        {
            _sprite.flipX = false;
        }
        
        
    }

    
}
