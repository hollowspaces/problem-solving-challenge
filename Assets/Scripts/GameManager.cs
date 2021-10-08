using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Circle;
    public GameObject Outline;

    public float mouseSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Circle.transform.position = Vector2.Lerp(Circle.transform.position, mousePosition, mouseSpeed * Time.deltaTime);
    }
}
