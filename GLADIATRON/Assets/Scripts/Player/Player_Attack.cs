using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public AudioSource somAtaque;
    Animator anim;//chama as animações
    Rigidbody rigidbody;
    protected BT_Attack BT_Attack;
    public Transform attackPoint; //ponto do ataque apartir da arma do personagem
    public LayerMask enemyLayers;

    public float attackRange = 0.5f; //distancia do ataque
    public int attackDamage = 40; //dano do ataque

    public float attackRate = 1f;
    float nextAttackTime = 1;

    protected BotoesLivres BotoesLivres;

    // Start is called before the first frame update
    void Start()
    {
        BT_Attack = FindObjectOfType<BT_Attack>();
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        BotoesLivres = GetComponent<BotoesLivres>();

    }

    // Update is called once per frame
    void Update()
    {
        //chama BotoesLivres
        // bool botoesLivres = !joystickPtr.Pressed && !BT_PULO.Pressed && !BT_Attack.Pressed;
    }

    public void Dano(int amount) //cura vida do player
    {
        attackDamage += amount;
    }
    public void Ataque()
    {
        if (Time.time >= nextAttackTime)
        {
          nextAttackTime = Time.time + 1f / attackRate;
          anim.SetTrigger("Ataque01");
           //Detectar os inimigos no alcance
           Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
            //Ataca-los
            foreach (Collider enemy in hitEnemies)
            {
              enemy.GetComponent<EHealth>().TakeDamage(attackDamage);
            }
        }
    }

        void OnDrawGizmosSelected() //utilizado para criar uma esfera de onde o ataque ira partir, para determinar a distancia do ataque
        {
            if (attackPoint == null)
                return;
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);

        }
    public void SAtaque()
    {
        somAtaque.Play();

    }


}
