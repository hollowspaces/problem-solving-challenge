using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Circle;
    public GameObject Outline;

    // Update is called once per frame
    void Update()
    {
        FollowMousePosition followMousePosition = Circle.AddComponent<FollowMousePosition>();
        followMousePosition.MousePosition();
    }
}
