using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pulo : MonoBehaviour
{
    protected BotoesLivres BotoesLivres;

    Animator anim;//chama as animações
    Rigidbody rigidbody;
    protected bool Jump;
    private float JumpTime;//limitando o pulo do Tigas
    public Transform chaoVerificador;
    public float ForcaPulo;
    // Start is called before the first frame update
    void Start()
    {
        
        rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        BotoesLivres = GetComponent<BotoesLivres>();
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.2f))
        {
            if (hit.transform.CompareTag("Chao"))
            {
                Jump = false;
            }
        }
        if (BotoesLivres && Input.GetButtonDown("Jump"))
        {
            Jump = true;
            anim.SetTrigger("Caindo");
            Pulo();
            
        }
    }
        public void Pulo()
        {
            if (!Jump)
            {
                rigidbody.velocity += Vector3.up * ForcaPulo;
                Jump = true;
                anim.SetTrigger("Pulando");

            }
        }
    
}
