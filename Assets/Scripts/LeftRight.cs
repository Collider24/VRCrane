using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    public CraneControl Cabine;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            Debug.Log("OK");

            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
            {
                Cabine.MoveUpCart(false);
                VibrationManager.singleton.TriggerVibration(OVRInput.Controller.LTouch);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
            {
                Cabine.MoveUpCart(true);
                VibrationManager.singleton.TriggerVibration(OVRInput.Controller.RTouch);
            }
        }
    }
}