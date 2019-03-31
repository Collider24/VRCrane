using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopButton : MonoBehaviour {

    public CraneControl Button;
    public GameObject LightGreen;
    public GameObject LightRed;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            Debug.Log("OK");
            Button.StartCrane(false);
            LightGreen.SetActive(false);
            LightRed.SetActive(true);
        }
    }
}
