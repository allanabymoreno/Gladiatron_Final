using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gira_OBJ : MonoBehaviour
{
    public float OBJspeed;
    public float RotX,RotY,RotZ;
    

    void Start()
    {

    }

    void Update()
    {
       transform.Translate(Vector3.left * OBJspeed * Time.deltaTime);
       transform.Rotate( 0,1 * Time.deltaTime * RotX, RotY);


    }
}
