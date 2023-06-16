using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public int gunDamage = 10;
    public float destroyDelay = 3f; // Délai avant de détruire la balle

    private void Start()
    {
        Destroy(gameObject, destroyDelay); // Détruire la balle après le délai spécifié
    }

    private void OnTriggerEnter(Collider other)
    {
        ReceiveDamage receiveDamage = other.GetComponent<ReceiveDamage>();
        if (receiveDamage != null)
        {
            receiveDamage.TakeDamageFromBullet(gunDamage);
        }
        Destroy(gameObject); // Détruire la balle lorsqu'elle entre en collision avec quelque chose
    }
}
