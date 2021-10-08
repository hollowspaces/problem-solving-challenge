using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    public SpawnBox spawnBox;
    public Text ScoreText;

    public bool currentScene;

    private int _score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If circle hit object with tag "Box", that object will be destroyed
        // and score increased by 1
        if (collision.gameObject.tag == "Box")
        {
            Destroy(collision.gameObject);
            _score += 1;

            if(currentScene)
            {
                Invoke("RespawnBox", 3f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + _score.ToString();
    }

    void RespawnBox()
    {
        spawnBox.totalBox -= 1;
    }
}
