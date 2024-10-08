using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRightLeft : MonoBehaviour
{
    public float speed;
    public float moveTime;

    private bool dirRight = false;
    private float timer;

    void Update()
    {
        if (dirRight) 
        { 
            transform.Translate(Vector2.right * speed * Time.deltaTime);    
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;

        if(timer >= moveTime)
        {
            dirRight = !dirRight;
            timer = 0f;
        }  
    }
}
