using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour

{
    public float timer;

    public float minTime = 5;
    public float maxTime = 10;
    public GameObject monJoueur;

    public Rigidbody2D monRigidBody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minTime, maxTime);
        monRigidBody.velocity = Vector3.down * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Destroy(monJoueur);
        }
        timer = Random.Range(minTime, maxTime);
        }
    }
    
