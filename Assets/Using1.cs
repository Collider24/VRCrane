using UnityEngine;
using System.Collections;

public class Using1 : MonoBehaviour {
	public static int RGB = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (RGB == 1) 
		{
			gameObject.GetComponent<Renderer> ().materials [0].shader = Shader.Find ("Toon/Basic Outline");
		}
		if (RGB == 0) 
		{
			gameObject.GetComponent<Renderer> ().materials [0].shader = Shader.Find ("Standard");	
		}

	}
}
