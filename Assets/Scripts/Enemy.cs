using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int MaxHealth = 100;
    int currentHealth;
    public GameObject bloodEffect;

    void Start()
    {
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //play hurt animation 
        animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
            {
                Die();
            }
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        //play hurt animation 
        animator.SetBool("IsDead", true);

        //destroy enemy
        GetComponent<Collider2D>().enabled = false;
    }

}
