using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using System.Collections;

public class CAMZoom : MonoBehaviour
{
    public GameObject Player;
    public GameObject MiniCam;
    public float ZoomOut = 52;
    public float ZoomIN = 150;
    private Vector3 offset;

    public float scrnHeight = 800f;
    public float scrnWidth = 480f;
    public float tempRation = 1;
    public const float fixedValue = 3f;
    //public Vector2 nativeRes = new Vector2 (480,800);
    void Awake()
    {
        scrnHeight = Screen.height;
        scrnWidth = Screen.width;
        tempRation = scrnWidth / scrnHeight;
        
        Camera.main.orthographicSize = fixedValue / tempRation;
    }
    void Start()
    {

    }

    void Update()
    {
        
        
    }
    public void Zoom_Out()
    {
        if (Input.GetButtonDown("ZoomMouse"))
        {
            
            Debug.Log("ZOOM++++");
        }
        else
        {
            Camera.main.orthographicSize = fixedValue + ZoomOut;
            //gameObject.transform.localScale = Vector3.one * ZoomOut / 6f;
            Debug.Log("zoom-");
            //transform.localPosition = new Vector3(0, ZoomOut, -22); // o valor do eixo y diminui, fazendo a altura da main camer diminuir tbm
        }

    }
   public void Zoom_In()
    {
        if (Input.GetButtonDown("ZoomMouse"))
        {
            Debug.Log("ZOOM----");
        }
        else
        {
            Camera.main.orthographicSize = fixedValue  + ZoomIN;
            //gameObject.transform.localScale = Vector3.one * ZoomIN / 6f;
            Debug.Log("zoom+");
            //transform.localPosition = new Vector3(0, ZoomIN, -22); // o valor do eixo y diminui, fazendo a altura da main camer diminuir tbm
        }
    }
}