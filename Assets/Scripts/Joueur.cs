using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public GameObject prefabBullet;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject jeViensDeNaitre = Instantiate(prefabBullet, transform.position, transform.rotation);
            //jeViensDeNaitre.GetComponent<Bullet>().monCreateur = this;

        }
    }
}
