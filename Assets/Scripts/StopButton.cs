using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopButton : MonoBehaviour {

    public CraneControl Button;
    public GameObject LightGreen;
    public GameObject LightRed;
    public StartButton IsDone;
    public GameObject Screen;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            IsDone.Done = false;
            Button.StartCrane(false);
            LightGreen.SetActive(false);
            LightRed.SetActive(true);
            Screen.SetActive(false);
        }
    }
}
