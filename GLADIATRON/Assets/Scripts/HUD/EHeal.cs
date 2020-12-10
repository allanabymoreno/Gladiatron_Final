using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHeal : MonoBehaviour
{
    
    
    //int curar = 50;

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
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<EHealth>();//.Cura(curar);
        }
        DestroyGameObject();
    }

    public virtual void DestroyGameObject()
    {
        Destroy(gameObject,0.2f);
    }

}

