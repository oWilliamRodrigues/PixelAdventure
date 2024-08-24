using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawLeftRight : MonoBehaviour
{
    public float speed;
    public float moveTime;

    private bool dirLeft = false;
    private float timer;

    void Update()
    {
        if (dirLeft)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;

        if(timer >= moveTime)
        {
            dirLeft = !dirLeft;
            timer = 0f;
        }

    }
}
