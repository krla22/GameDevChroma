using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image HealthBarUI;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    PlayerMovement Player;
    public Gradient gradient;

    private void Start()
    {
        HealthBarUI = GetComponent<Image>();
        Player = FindObjectOfType<PlayerMovement>();
    }
    
    private void Update()
    {
        CurrentHealth = Player.Health;
        HealthBarUI.fillAmount = CurrentHealth / MaxHealth;
    }
}
