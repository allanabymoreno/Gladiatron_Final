using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EHealth : MonoBehaviour
{
    public Animator anim;

    public int PONTO_MORTE = 1;
    public Slider Eslider;
    public Gradient Egradient;
    public Image Efill;

    //public GameObject DROP; //escolhe o objeto CHAVE ser dropado
    //chama as animações

    public int maxEHealth; //vida maxima
    public int currentEHealth; // vida atual

    public EHealth EhealthBar;

    void Start()
    {
        currentEHealth = maxEHealth;
        
    }

    void Update()
    {
        EhealthBar.SetMaxEHealth(maxEHealth);
        EhealthBar.SetEHealth(currentEHealth);

        if(currentEHealth >= maxEHealth)
        {
            currentEHealth = maxEHealth;
        }
    }

    public void SetMaxEHealth(int Ehealth) 
    {
        Eslider.maxValue = Ehealth;
        Eslider.value = Ehealth;
        Efill.color = Egradient.Evaluate(1f);
    }

   /* public void Cura(int amount) //cura vida do player
    {
        currentEHealth += amount;

    }*/

    public void TakeDamage(int damage) //recebe dano
    {
        currentEHealth -= damage;
        anim.SetTrigger("Hurt");
        EhealthBar.SetEHealth(currentEHealth);
        
        if (currentEHealth <= 0)
        {
            ContPontos.PONTOS += PONTO_MORTE;
            currentEHealth = 0;
            anim.SetBool("EMorrendo", true);
            Die();
            //SOME(); //destroi o game object, depois trocar para animação de morrer
            
        }
           
    }

    public virtual void Die()//função virtual para informar que o objeto morreu
    {
        Debug.Log(transform.name + " Died");
        GetComponent<Collider>().enabled = false;
        this.enabled = true;
        SOME();
        
    }
    public virtual void SOME()
    {
        // DROP.SetActive(true);
        // GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        Destroy(gameObject, 1f);
        


    }

    public void SetEHealth(int EHealth) //um slider e um gradiente para mexer na barra de vida
    {
        Eslider.value = EHealth;
        Efill.color = Egradient.Evaluate(Eslider.normalizedValue);
    }

}
