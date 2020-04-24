using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnergy : MonoBehaviour
{
    public int maxHealth;

    private int currentHealth;
    public barController halthBar;

    Animator animator;
    void Start()
    {
        currentHealth = maxHealth;
        halthBar.SetHealth(maxHealth);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        animator.SetInteger("Health", currentHealth);
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        halthBar.SetHealth(currentHealth);
    }

    public void TakeEnergy(int energy){
        currentHealth += energy;
        halthBar.SetHealth(currentHealth);
    }

    public int GetHealth(){
        return currentHealth;
    }
}
