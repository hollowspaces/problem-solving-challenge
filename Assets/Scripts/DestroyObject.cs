using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    public Text ScoreText;
    private int score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If circle hit object with tag "Box", that object will be destroyed
        // and score increased by 1
        if (collision.gameObject.tag == "Box")
        {
            Destroy(collision.gameObject);
            score += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + score.ToString();
    }
}
