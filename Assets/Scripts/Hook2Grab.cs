using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook2Grab : MonoBehaviour {

    public bool Grabbed = false;
    public bool InTrigger = false;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hook2")
        {
            Grabbed = true;
            InTrigger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hook2")
        {
            InTrigger = false;
            Grabbed = false;
        }
    }
}
