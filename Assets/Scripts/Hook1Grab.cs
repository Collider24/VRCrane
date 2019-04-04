using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook1Grab : MonoBehaviour {

    public bool Grabbed = false;
    public bool InTrigger = false;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hook1")
        {
            Grabbed = true;
            InTrigger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hook1")
        {
            Grabbed = false;
            InTrigger = false;
        }
    }
}
