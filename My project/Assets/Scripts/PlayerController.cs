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
    

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); 
        float y = Input.GetAxisRaw("Vertical"); 
        direction = new Vector2(x, y).normalized; 

        if (direction.magnitude > 0) 
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); 
        }
    }

    void FixedUpdate()
    {
        playerRigidbody2D.MovePosition(playerRigidbody2D.position + direction * speed * Time.fixedDeltaTime); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Warrior"))
        {
            
        }
    }
}
