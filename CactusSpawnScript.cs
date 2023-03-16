using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawnScript : MonoBehaviour
{
    public GameObject cactus;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawnCactus();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) 
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCactus();
            timer = 0;
            
        }
       
    }

    void spawnCactus()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(cactus, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
