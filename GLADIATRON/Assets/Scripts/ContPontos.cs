using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContPontos : MonoBehaviour
{
    public static int PONTOS;
    public GameObject DROP1, DROP2, DROP3, DROP4; //escolhe o objeto CHAVE ser dropado
    void Awake()
    {
        PONTOS = 0;
    }
    void Start()
    {

    }
    void Update()
    {
       // Debug.Log("PONTOS: " + PONTOS);
        DROP_ITEM();
    }
    public void DROP_ITEM()
    {
        if(PONTOS >= 1)
        {
         DROP1.SetActive(true); // dropa a CHAVE
        }
        if (PONTOS >= 5)
        {
            DROP2.SetActive(true); // dropa a CHAVE
        }
        if (PONTOS >= 9)
        {
            DROP3.SetActive(true); // dropa a CHAVE
        }
        if (PONTOS >= 12)
        {
            DROP4.SetActive(true); // dropa a CHAVE
        }
    }
}
