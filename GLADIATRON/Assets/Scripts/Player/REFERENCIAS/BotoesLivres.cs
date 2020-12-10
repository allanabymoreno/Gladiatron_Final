using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotoesLivres : MonoBehaviour
{
    //botoes livres
    protected BT_Attack BT_Attack;
    protected Joystick joystick;
    protected JoystickPointer joystickPtr;
    protected BT_PULO BT_PULO;

    // Start is called before the first frame update
    void Start()
    {
        //botoes livres
        joystick = FindObjectOfType<Joystick>();
        joystickPtr = FindObjectOfType<JoystickPointer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        bool botoesLivres = !joystickPtr.Pressed && !BT_PULO.Pressed && !BT_Attack.Pressed;
    }
}
