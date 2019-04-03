using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Richpoint : MonoBehaviour {
    public bool Riched = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Container") {
            Riched = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Container")
        {
            Riched = false;
        }
    }
}
