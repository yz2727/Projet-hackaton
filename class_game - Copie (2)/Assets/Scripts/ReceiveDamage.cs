using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveDamage : MonoBehaviour
{
    public GameObject arme; // Référence vers l'arme du joueur

    private EnemyColor enemyColor; // Référence au script EnemyColor

    private void Start()
    {
        enemyColor = GetComponent<EnemyColor>(); // Récupère le script EnemyColor attaché à l'ennemi
    }

    private void OnTriggerEnter(Collider other)
    {
        Bullet1 bullet = other.GetComponent<Bullet1>();
        if (bullet != null)
        {
            enemyColor.TakeDamage(); // Appelle la méthode TakeDamage() du script EnemyColor pour changer la couleur de l'ennemi
            Destroy(bullet.gameObject);
            arme.SetActive(false); // Désactive l'arme du joueur
        }
    }

    public void TakeDamageFromBullet(int amount)
    {
        // Cette méthode peut être laissée vide, car elle n'est pas utilisée pour l'instant
        // Vous pouvez ajouter ici d'autres fonctionnalités spécifiques à l'ennemi en cas de dommages par balle
    }
}
