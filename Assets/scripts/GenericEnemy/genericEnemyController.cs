using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericEnemyController : MonoBehaviour
{
    public float speed = 2f;
    public float minX = -5f;
    public float maxX = 5f; 

    private bool movingRight = true; 

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (transform.position.x >= maxX)
        {
            movingRight = false; 
        }
        else if (transform.position.x <= minX)
        {
            movingRight = true; 
        }
    }
}
