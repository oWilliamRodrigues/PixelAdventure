using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawTopDown : MonoBehaviour
{
    public float speed;
    public float moveTime;

    private bool dirTop = true;
    private float timer;

    void Update()
    {
        if (dirTop)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;

        if (timer >= moveTime)
        {
            dirTop = !dirTop;
            timer = 0f;
        }
    }
}
