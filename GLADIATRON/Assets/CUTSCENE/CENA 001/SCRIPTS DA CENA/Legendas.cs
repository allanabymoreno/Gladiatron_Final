using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Legendas : MonoBehaviour {
	Text Legens;
	// Use this for initialization
	void Start () {
		Legens = GameObject.Find ("Legenda").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void legendas(string lengs){
		Legens.text = lengs;
	}
}
