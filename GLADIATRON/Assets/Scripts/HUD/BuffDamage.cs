using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffDamage : MonoBehaviour
{
    public LayerMask playerLayers;

   public int dano = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnTriggerEnter(Collider other)// função para dar dano
    {

        other.gameObject.GetComponent<Player_Attack>().Dano(dano);
        DestroyGameObject();

    }

    public virtual void DestroyGameObject()
    {
        Destroy(gameObject, 0.5f);
    }

}