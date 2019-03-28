using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLever : MonoBehaviour
{
    public CraneControl Cabine;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
            {
                Cabine.MoveAllCrane(true);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
            {
                Cabine.MoveAllCrane(false);
            }
        }
    }
}