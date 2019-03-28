using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCrane : MonoBehaviour {

    public CraneControl StartCraneButton;

	void Start () {
        StartCraneButton.StartCrane(true);
	}
}
