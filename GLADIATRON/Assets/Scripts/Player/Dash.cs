using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    protected Joystick joystick;
    public float Velocidade = 30;
    public float VelMax = 200;

    Animator anim;
    Rigidbody rigidbody;

    public float forcaDash, desaceleracaoDash;

    float dash = 1;
    float dash_t = 0;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dash = CalculaDash();
        anim.SetTrigger("Dash");
        Vector3 vel = new Vector3(
         joystick.Horizontal * Velocidade + Input.GetAxis("Horizontal") * Velocidade,
          0,
          joystick.Vertical * Velocidade + Input.GetAxis("Vertical") * Velocidade
          ) * dash;
        if (vel.magnitude > 0.1f)//direção do personagem 
        {
            Vector3 direcaoParaOlhar = transform.position + vel * 3;
            transform.LookAt(direcaoParaOlhar);
        }

        //movimentação com animação de movimento
        rigidbody.velocity = new Vector3(vel.x, rigidbody.velocity.y, vel.z);

        anim.SetBool("Correndo", vel.magnitude > 0.1);


    }

    float CalculaDash()
    {
        anim.SetTrigger("Dash");
        // [-Inf, 1]
        dash_t -= desaceleracaoDash * Time.deltaTime;

        // [-Inf, 1] -> [0, 1]
        float dash01 = Mathf.Clamp01(dash_t);

        // [0, 1] -> [0, fD-1] | fD = forcaDash
        float dashFDm1 = dash01 * (forcaDash - 1);

        // [0, fD-1] -> [1, fD]
        float dashFinal = dashFDm1 + 1;
        return dashFinal;
    }

    public void AplicarDash()
    {

        dash_t = 1;
    }
}
