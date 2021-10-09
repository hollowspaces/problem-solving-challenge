using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject Box;

    public int minSpawn = 15; 
    public int maxSpawn = 40;
    public int totalBox;

    private Vector2 _randomPos;
    private int _randomSpawn;

    // Start is called before the first frame update
    private void Start()
    {
        _randomSpawn = Random.Range(minSpawn, maxSpawn);
    }

    // Update is called once per frame
    private void Update()
    {   
        if (totalBox < _randomSpawn)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        bool boxSpawned = false;
        while (!boxSpawned)
        {
            Vector3 boxPos = new Vector3(Random.Range(-7.6f, 7.6f), Random.Range(-3.8f, 3.8f), 0f);
            if ((boxPos - transform.position).magnitude < 2)
            {
                continue;
            } else
            {
                Instantiate(Box, boxPos, Quaternion.identity);
                totalBox += 1;
                boxSpawned = true;
            }
        }
    }
}
