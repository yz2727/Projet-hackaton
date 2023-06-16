using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class EnemyColor : MonoBehaviour
{
    private Renderer enemyRenderer;
    private Color initialColor;
    public List<Color> hitColors = new List<Color>(); // Liste de couleurs de l'ennemi lorsqu'il est touché

    // Événement déclenché lorsque l'ennemi est touché
    public UnityEvent OnEnemyHit;

    private void Start()
    {
        enemyRenderer = GetComponent<Renderer>();
        initialColor = enemyRenderer.material.color;
    }

    public void TakeDamage()
    {
        if (hitColors.Count > 0)
        {
            // Choix d'une couleur aléatoire parmi la liste de couleurs hitColors
            int randomIndex = Random.Range(0, hitColors.Count);
            Color randomColor = hitColors[randomIndex];

            enemyRenderer.material.color = randomColor; // Changement de couleur de l'ennemi lorsqu'il est touché par les munitions

            // Déclencher l'événement d'ennemi touché
            if (OnEnemyHit != null)
            {
                OnEnemyHit.Invoke();
            }
        }
    }

    // Le reste de votre code...
    // Vous pouvez ajouter d'autres méthodes ou fonctionnalités spécifiques à votre ennemi ici
    // Start(), Update() ou tout autre code que vous souhaitez ajouter
    // Assurez-vous simplement de ne pas modifier ou supprimer les parties existantes du script EnemyColor
}
