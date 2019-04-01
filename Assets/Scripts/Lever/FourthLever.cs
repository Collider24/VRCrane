using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthLever : MonoBehaviour {
    public CraneControl Cabine;
    public OVRPlayerController Move;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            Move.EnableLinearMovement = false;
            if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
            {
                Cabine.CalibrateThirdHook(true);
            }
            if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown))
            {
                Cabine.CalibrateThirdHook(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Move.EnableLinearMovement = true;
    }
}