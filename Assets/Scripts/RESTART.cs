using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESTART : MonoBehaviour {

    public string scene;

	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(scene);
        }
	}
}
