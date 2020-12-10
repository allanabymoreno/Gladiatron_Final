using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    Animator anim;//chama as animações
    public GameObject SomePlayer;

    public int maxHealth; //vida maxima
    public int currentHealth; // vida atual

    public Health healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);

        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void SetMaxHealth(int health) 
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }

    public void Cura(int amount) //cura vida do player
    {
        currentHealth += amount;

    }

    public void TakeDamage(int damage) //recebe dano
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
            anim.SetTrigger("Morrendo");
            //DestroyGameObject(); //destroi o game object, depois trocar para animação de morrer
            SomePlayer.SetActive(false);
            VaiGAMEOVER();
        }
           
    }

    public virtual void Die()//função virtual para informar que o objeto morreu
    {
        Debug.Log(transform.name + " Died");
    }
    public virtual void DestroyGameObject()
    {
        
    }

    public void SetHealth(int Health) //um slider e um gradiente para mexer na barra de vida
    {
        slider.value = Health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    public void VaiGAMEOVER()
    {
        SceneManager.LoadScene("GAMEOVER");
    }
}
