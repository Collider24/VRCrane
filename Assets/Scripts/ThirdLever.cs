using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLever : MonoBehaviour
{
    public CraneControl Cabine;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
            {
                Cabine.MoveDownCart(false);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
            {
                Cabine.MoveDownCart(true);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
            {
                Cabine.MoveThirdHook(true);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
            {
                Cabine.MoveThirdHook(false);
            }
        }
    }
}