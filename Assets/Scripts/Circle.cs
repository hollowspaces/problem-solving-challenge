using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    // Gaya yang diberikan untuk mendorong bola
    private float x = 1.5f;
    private float y = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        Invoke("MoveObject", 1f);
    }

    void MoveObject()
    {
        float direction1 = Random.Range(0, 1);
        float direction2 = Random.Range(0, 1);

        // Normalize
        if (direction1 == 1)
        {
            y *= -1;
        }
        else
        {
            y *= 1;
        }

        if (direction2 == 1)
        {
            x *= -1;
        }
        else
        {
            x *= 1;
        }
        rigidBody2D.AddForce(new Vector2(x * 100, y * 100));
    }
}
