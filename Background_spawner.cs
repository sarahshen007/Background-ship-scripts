using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_spawner : MonoBehaviour
{

    public GameObject spaceship;

    public float maxTime = 10.0f;

    public float minTime = 5.0f;

    private float spawnTime;

    private float time;

    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = transform;
        time = 0.0f;
        updateSpawnTime();
    }

    void updateSpawnTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= spawnTime)
        {
            Instantiate(spaceship, tr.position, tr.rotation);
            updateSpawnTime();
            time = 0.0f;
        }
    }
}
