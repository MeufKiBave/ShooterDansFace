using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
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
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(BulletEnemy, parent.position,parent.rotation);
        }
        transform.Translate(Vector2.down*speed);        
    }
}
