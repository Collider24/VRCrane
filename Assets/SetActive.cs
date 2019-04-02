using UnityEngine;
using System.Collections;

public class SetActive : MonoBehaviour {
	public Texture2D CursoreTexture;
	public Transform RaycastS;
	private RaycastHit Hit;
	void Start () {
		Cursor.visible = false;
	}

	void Update () 
	{
		Vector3 Direction = RaycastS.TransformDirection (Vector3.forward);
		if (Physics.Raycast (RaycastS.position, Direction, out Hit, 1000f))
		{
			Quaternion HitRotation = Quaternion.FromToRotation (Vector3.up, Hit.normal);
			if (Hit.collider.material.staticFriction == 0.2f)
			{
				Using1.RGB = 1;

			}
			else
			{
				Using1.RGB = 0;
			}
		
		}
	}
	void OnGUI()
	{
		GUI.DrawTexture (new Rect (Screen.width / 2, Screen.height / 2, 15, 15), CursoreTexture);
	}
}
