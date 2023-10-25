using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public float timer;

    public float minTime= 5;
    public float maxTime =10;

    public GameObject enemy1;
    public GameObject enemy2;

    private void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;    
        if(timer<=0)
        {
            if(Random.Range(0,2)>=1)
            {
                Instantiate(enemy1, transform.position, transform.rotation);
            }
            else
            {
                Instantiate(enemy2, transform.position, transform.rotation);
            }
            timer = Random.Range(minTime, maxTime);

        }

    }
}
