using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    public Animator animator;

    public float Health = 100f;
    public float Stability = 100f;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
           TakeDamage();
           StabilityEffect();
        }
    }

    void TakeDamage()
    {
        Health = Health - 10f;

        //play hurt animation
        animator.SetTrigger("Hurt");

        if(Health <= 0)
            {
                Die();
                Invoke("LoadGameOverScreen", 2);
            }
    }

    public void LoadGameOverScreen()
    {
        SceneManager.LoadScene("GameOverScreen");
    }
    

    void Die()
    {
        Debug.Log("Player died!");

        //play hurt animation 
        animator.SetBool("IsDead", true);
    }

    void StabilityEffect()
    {
        Stability = Stability + 5f;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
    }

    public void OnLanding ()
    {
         animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
