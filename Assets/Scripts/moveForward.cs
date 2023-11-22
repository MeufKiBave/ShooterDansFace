using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float timer;

    public float minTime = 7;
    public float maxTime = 10;

    public GameObject BulletEnemy;
    public Transform parent;
    public GameObject enemy;

    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()

    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (Random.Range(0, 2) >= 1)
            {
                Instantiate(BulletEnemy, parent.position, parent.rotation);
            }
            timer = Random.Range(minTime, maxTime);
        }
        transform.Translate(Vector2.down*speed);        
    }
}
