using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public GameObject healthDropPrefab; // Prefab for the health drop

    private Transform target;
    private NavMeshAgent agent;
    private float damageCooldown = 2f; // Delay in seconds for taking damage
    private float lastDamageTime = 0f; // Time of last damage dealt
    public enum EnemyState
    {
        Chase,
        Patrol
    }

    public EnemyState state; // Current state of the enemy
    public PlayerHealth playerHealth; // Reference to the player's health component
    public Transform[] patrolPoints; // Array of patrol points
    private int pathIndex = 0; // Current index in the patrol points
    public float distThreshold = 0.2f; // Distance threshold for patrol points

    // Enemy stats
    public float health = 10f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (player == null)
        {
            Debug.LogError("Player transform not assigned to Enemy.");
        }
    }

    void Update()
    {
        if (player == null) return;

        if (state == EnemyState.Patrol)
        {
            Patrol();
        }
        else if (state == EnemyState.Chase)
        {
            Chase();
        }
    }

    void Patrol()
    {
        // Set target to patrol point if not already set
        if (target == null || target == player)
        {
            target = patrolPoints[pathIndex];
        }

        // Check if the enemy has reached the patrol point
        if (agent.remainingDistance < distThreshold)
        {
            pathIndex = (pathIndex + 1) % patrolPoints.Length; // Move to the next patrol point
            target = patrolPoints[pathIndex];
        }

        // Set the destination for the NavMeshAgent
        agent.SetDestination(target.position);
    }

    void Chase()
    {
        target = player;
        agent.SetDestination(target.position);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log($"Enemy took {amount} damage. Remaining health: {health}");

        if (health <= 0)
        {
            Die();
        }
    }
        
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the enemy collides with the player's weapon
        Weapon weapon = collision.gameObject.GetComponent<Weapon>();

        if (weapon != null)
        {
            // Apply damage to the enemy
            float damageAmount = 10f; // Assuming a fixed damage value of 10 from the weapon
            TakeDamage(damageAmount);
            Debug.Log($"Enemy collided with weapon. Took {damageAmount} damage.");
        }

        // Check if the enemy collides with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Check if enough time has passed since the last damage was dealt
            if (Time.time - lastDamageTime >= damageCooldown)
            {
                float playerDamage = 10f; // Amount of damage to deal to the player
                playerHealth.TakeDamage(playerDamage);
                lastDamageTime = Time.time; // Update the last damage time
                Debug.Log($"Enemy dealt {playerDamage} damage to the player. Player's remaining health: {playerHealth.health}");
            }
        }
    }

    void Die()
    {
        // Drop health pickup if prefab is assigned
        if (healthDropPrefab != null)
        {
            Instantiate(healthDropPrefab, transform.position, Quaternion.identity);
        }

        // Log the death of the enemy
        Debug.Log("Enemy died!");

        // Destroy the enemy object after a delay
        Destroy(gameObject, 2f); // Adjust the delay as needed
    }
}
