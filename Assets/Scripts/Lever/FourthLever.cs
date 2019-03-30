using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthLever : MonoBehaviour {
    public CraneControl Cabine;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
            {
                Cabine.CalibrateSecondHook(true);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
            {
                Cabine.CalibrateSecondHook(false);
            }
        }
    }
}