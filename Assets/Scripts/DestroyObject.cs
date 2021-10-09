using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    public SpawnBox spawnBox;
    public Text ScoreText;
    public Transform CircleTransform;
    public AudioClip sFx;

    public bool currentScene;
    public bool scene9;

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
                
                if (scene9)
                {
                    AudioManager.Instance.PlaySfx("fish-sfx");
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + _score.ToString();

        if (scene9)
        {
            if (_score == 20)
            {
                CircleTransform.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            }
            else if (_score == 50 && CircleTransform.transform.localScale.x == 0.4f)
            {
                CircleTransform.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
            else if (_score == 90 && CircleTransform.transform.localScale.x == 0.5f)
            {
                CircleTransform.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
            else if (_score == 140 && CircleTransform.transform.localScale.x == 0.6f)
            {
                CircleTransform.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
            else if (_score == 200 && CircleTransform.transform.localScale.x == 0.7f)
            {
                CircleTransform.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
        }
    }

    void RespawnBox()
    {
        spawnBox.totalBox -= 1;
    }
}
