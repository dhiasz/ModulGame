using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcStatic : MonoBehaviour
{

    public float speed = 5f;
    void Update()
    {
        
    }

    void move()
    {
        float moveX = Input.GetAxis("horizontal");
        float moveY = Input.GetAxis("vertical");

        Vector2 movement = new Vector2(moveX, moveY).normalized;

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
