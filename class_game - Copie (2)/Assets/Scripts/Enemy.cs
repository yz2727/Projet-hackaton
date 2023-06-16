using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask playerLayer;
    public float visionRange;
    public float followRange;
    public float patrolRange;
    private Vector3 currentDestination;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 3f; // Réduire la vitesse de déplacement de l'ennemi

        // Définir une destination aléatoire initiale
        SetRandomDestination();
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        bool inVisionRange = distanceToPlayer <= visionRange;
        bool inFollowRange = distanceToPlayer <= followRange;

        if (inVisionRange && inFollowRange)
        {
            agent.SetDestination(player.position);
            agent.speed = 5f; // Augmenter la vitesse de déplacement lorsqu'il suit le joueur
        }
        else
        {
            // Si l'ennemi n'est pas en train de suivre le joueur, effectuer les mouvements en boucle
            Patrol();
        }
    }

    private void Patrol()
    {
        // Vérifier si l'ennemi a atteint sa destination actuelle
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            // Définir une nouvelle destination aléatoire
            SetRandomDestination();
        }
    }

    private void SetRandomDestination()
    {
        // Générer une position aléatoire à l'intérieur d'un rayon de patrolRange
        Vector3 randomDirection = Random.insideUnitSphere * patrolRange;
        randomDirection += transform.position;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randomDirection, out navHit, patrolRange, NavMesh.AllAreas);

        // Définir la nouvelle destination
        currentDestination = navHit.position;
        agent.SetDestination(currentDestination);
    }
}
