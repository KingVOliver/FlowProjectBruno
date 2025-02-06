using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;

    public int maxHealth = 100;
    public int currentHealth;

    public int maxAtack = 50;
    public int currentAtack;

    public float speed = 5f;
    private float defaultSpeed;

    public Slider healthBar;
    public Slider atackBar;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        currentHealth = maxHealth;
        currentAtack = maxAtack;
        defaultSpeed = speed;

        UpdateUI();
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        UpdateUI();
        Debug.Log($"Healed! Current Health: {currentHealth}");
    }

    public void AtackBoost(int amount)
    {
        currentAtack = Mathf.Min(currentAtack + amount, maxAtack);
        UpdateUI();
        Debug.Log($"atack Restored! Current atack: {currentAtack}");
    }

    public void SpeedBoost(float boostAmount, float duration)
    {
        speed += boostAmount;
        Debug.Log($"Speed Boosted! New Speed: {speed}");
        Invoke(nameof(ResetSpeed), duration); // Revert speed after duration
    }

    private void ResetSpeed()
    {
        speed = defaultSpeed;
        Debug.Log("Speed Boost Ended.");
    }

    private void UpdateUI()
    {
        healthBar.value = (float)currentHealth / maxHealth;
        atackBar.value = (float)currentAtack / maxAtack;
    }
}