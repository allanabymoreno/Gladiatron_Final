using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack02 : MonoBehaviour
{
    public AudioSource somAtaque02;
    Animator anim;//chama as animações
    Rigidbody rigidbody;
    protected BT_COMBO BT_Combo;
    public Transform attackPoint; //ponto do ataque apartir da arma do personagem
    public LayerMask enemyLayers;

    public float attackRange = 0.5f; //distancia do ataque
    public int attackDamage = 40; //dano do ataque

    public float attackRate = 2f;
    float nextAttackTime = 0;

    protected BotoesLivres BotoesLivres;

    // Start is called before the first frame update
    void Start()
    {
        BT_Combo = FindObjectOfType<BT_COMBO>();
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        BotoesLivres = GetComponent<BotoesLivres>();

    }

    // Update is called once per frame
    void Update()
    {
        //chama BotoesLivres
        // bool botoesLivres = !joystickPtr.Pressed && !BT_PULO.Pressed && !BT_Attack.Pressed;
        

        if (BotoesLivres && Input.GetButtonDown("Fire2"))
        {
            Ataque();
        }
    }

    public void Dano(int amount) //cura vida do player
    {
        attackDamage += amount;
    }
    public void Ataque()
    {
            anim.SetTrigger("Ataque02");
            //Detectar os inimigos no alcance
            Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
            //Ataca-los
            foreach (Collider enemy in hitEnemies)
            {
                enemy.GetComponent<EHealth>().TakeDamage(attackDamage);
            }

    }

        void OnDrawGizmosSelected() //utilizado para criar uma esfera de onde o ataque ira partir, para determinar a distancia do ataque
        {
            if (attackPoint == null)
                return;
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);

        }
    public void SAtaque02()
    {
        somAtaque02.Play();

    }

}
