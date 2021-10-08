using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject Box;

    public Vector2 minPos, maxPos;
    private Vector2 _randomPos;

    public int minSpawn, maxSpawn;
    public int totalBox;

    private int _randomSpawn;

    // Start is called before the first frame update
    void Start()
    {
        _randomSpawn = Random.Range(minSpawn, maxSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(minPos.x, maxPos.x);
        float y = Random.Range(minPos.y, maxPos.y);

        _randomPos = new Vector2(x, y);

        if (totalBox < _randomSpawn)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(Box, _randomPos, Quaternion.identity);
        totalBox += 1;
    }
}
