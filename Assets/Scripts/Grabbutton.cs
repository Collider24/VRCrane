using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbutton : MonoBehaviour
{

    public bool Grabbed = false;
    public Grabber IsInTrigger;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if ((OVRInput.GetUp(OVRInput.Button.Four)) && IsInTrigger.InTrigger)
            {
                Grabbed = !Grabbed;
            }
        }
    }
}