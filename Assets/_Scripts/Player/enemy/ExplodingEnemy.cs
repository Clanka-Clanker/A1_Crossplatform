using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent), typeof(AudioSource), typeof(Animator))]
public class ExplodingEnemy : MonoBehaviour
{
    public PlayerHealth Ph;
    public float explosionDelay = 5f; // Delay before explosion
    public float explosionRadius = 5f; // Radius of the explosion
    public float explosionDamage = 50f; // Damage dealt by the explosion
    public GameObject explosionPrefab; // Prefab for the explosion effect
    public AudioClip explosionSound; // Sound effect for the explosion
    public AudioClip walkingSound; // Sound effect for walking

    public float health = 1f; // Enemy health, set to 1

    private NavMeshAgent agent;
    private Transform player;
    private AudioSource audioSource;
    private Animator animator;

    private bool isExploding = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>(); // Get the Animator component
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        Ph = GetComponent<PlayerHealth>();
        if (player == null)
        {
            Debug.LogError("Player not found. Make sure the player has the 'Player' tag.");
        }

        // Start playing the walking sound
        if (walkingSound != null)
        {
            audioSource.clip = walkingSound;
            audioSource.loop = true;
            audioSource.Play();
        }
   
    }



    void Update()
    {
        if (player != null && !isExploding)
        {
            agent.SetDestination(player.position);
            PlayWalkingAnimation(); // Play walking animation

            // Check if close enough to start the explosion
            if (Vector3.Distance(transform.position, player.position) <= explosionRadius)
            {
                StartExplosion();
            }
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        // If health drops to 0 or below, trigger the death animation and destroy the enemy
        if (health <= 0f && !isExploding)
        {
            TriggerDeathAnimation();
            Die();
        }
    }

    void StartExplosion()
    {
        if (isExploding) return;

        isExploding = true;
        agent.isStopped = true; // Stop moving
        if (audioSource.isPlaying && walkingSound != null)
        {
            audioSource.Stop(); // Stop the walking sound
        }

        Debug.Log("Explosion started!");

        // Start the explosion countdown
        Invoke(nameof(Explode), explosionDelay);
    }

    void Explode()
    {
        if (!isExploding) return; // Prevent accidental call if already dead

        // Instantiate explosion effect
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }

        // Play explosion sound
        if (explosionSound != null)
        {
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
        }

        // Damage the player if within radius
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in hitColliders)
        {
            if (collider.CompareTag("Player"))
            {
                PlayerHealth playerHealth = collider.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(explosionDamage);
                }
            }
        }
        
        TriggerDeathAnimation();
        // Destroy the enemy
        Destroy(gameObject);
        Debug.Log("Enemy exploded and removed from the game.");
    }

    void Die()
    {
        // Stop all explosion-related effects
        if (isExploding) CancelInvoke(nameof(Explode));

        //  the enemy
        Destroy(gameObject);
        Debug.Log("Enemy killed before exploding.");
    }

    void PlayWalkingAnimation()
    {
        if (agent.velocity.magnitude > 0) // Check if the enemy is moving
        {
            if (Vector3.Dot(agent.velocity.normalized, transform.forward) > 0.5f) // Forward
            {
                animator.Play("PA_Warriorforward_Clip");
            }
            else if (Vector3.Dot(agent.velocity.normalized, -transform.forward) > 0.5f) // Backward (if you want backward animation)
            {
                animator.Play("PA_Warriorbackward_Clip"); // You need to create this animation if you want it
            }
            else if (Vector3.Dot(agent.velocity.normalized, transform.right) > 0.5f) // Right
            {
                animator.Play("PA_Warriorright_Clip");
            }
            else if (Vector3.Dot(agent.velocity.normalized, -transform.right) > 0.5f) // Left
            {
                animator.Play("PA_Warriorleft_Clip");
            }
        }
    }

    void TriggerDeathAnimation()
    {
        animator.Play("PA_Warrior Death_Clip"); // Play death animation
        // Wait for the duration of the death animation before destroying the enemy
        Invoke(nameof(Die), 1f); // Assuming the death animation is 2 seconds long
    }

    private void OnDrawGizmosSelected()
    {
        // Draw the explosion radius in the editor for visualization
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the enemy collides with the player's weapon
        Weapon weapon = collision.gameObject.GetComponent<Weapon>();
        if (weapon != null)
        {
            // Apply damage to the enemy
            TakeDamage(10f); // Assuming a fixed damage value of 10 from the weapon
        }
    }
}

