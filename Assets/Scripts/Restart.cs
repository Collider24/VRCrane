using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
    public string Level;
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Level);
        }
	}
}
