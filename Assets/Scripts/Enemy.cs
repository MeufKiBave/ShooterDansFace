using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Joueur monJoueur;

    private void OnCollisionEnter(Collision collision)
    {
        monJoueur = collision.gameObject.GetComponent<Joueur>();
        if(monJoueur == true)
        {
            monJoueur.Score++;
            Destroy(gameObject);
        }
    }

}
