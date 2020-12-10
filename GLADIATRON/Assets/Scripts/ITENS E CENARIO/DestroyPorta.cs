using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPorta : MonoBehaviour
{
    //public Transform PORTA;
    public GameObject PORTA;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            
            //Destroy(this.transform.parent.gameObject);
           // Destroy(GameObject.Find("porta"));
           PORTA.SetActive(false);
            //Destroy(PORTA);
            Destroy(this.gameObject);
        }
    }
}
