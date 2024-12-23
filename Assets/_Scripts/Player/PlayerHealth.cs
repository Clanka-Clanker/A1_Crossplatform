using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;
    public Slider healthBar; // Reference to the Slider UI component
   
    private void Start()
    {
        // Ensure the health bar is properly set
        if (healthBar == null)
        {
            Debug.LogError("HealthBar Slider not assigned!");
        }
        else
        {
            healthBar.maxValue = 100f; // Set the maximum value of the health bar
            healthBar.value = health; // Initialize the health bar value
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, 100f); // Ensure health doesn't go below 0
        UpdateHealthUI();

        if (health <= 0)
        {
            Die();
        }
    }

    public void RestoreHealth(float amount)
    {
        health += amount;
        health = Mathf.Clamp(health, 0, 100f); // Ensure health doesn't exceed 100
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        if (healthBar != null)
        {
            healthBar.value = health; // Update the health bar slider
        }
    }

    void Die()
    {
        
        SceneManager.LoadScene("Death");
        Debug.Log("Player has died!");
        // Add death logic (e.g., restart game, show game over screen)
    }
}
