using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StabilityBar : MonoBehaviour
{
    private Image StabilityBarUI;
    public float CurrentStability;
    private float MaxStability = 100f;
    PlayerMovement Player;

    private void Start()
    {
        StabilityBarUI = GetComponent<Image>();
        Player = FindObjectOfType<PlayerMovement>();
    }
    
    private void Update()
    {
        CurrentStability = Player.Stability;
        StabilityBarUI.fillAmount = CurrentStability / MaxStability;
    }
}
