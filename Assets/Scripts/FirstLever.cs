using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLever : MonoBehaviour
{
    public CraneControl Cabine;
    public TumblerMechanics Pos;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
            {
                Cabine.MoveUpCart(false);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
            {
                Cabine.MoveUpCart(true);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
            {
                if (Pos.Position == 0)
                    Cabine.MoveFirstHook(true);
                else if (Pos.Position == 1)
                    Cabine.MoveSecondHook(true);
                else
                {
                    Cabine.MoveFirstHook(true);
                    Cabine.MoveSecondHook(true);
                }
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
            {
                if (Pos.Position == 0)
                    Cabine.MoveFirstHook(false);
                else if (Pos.Position == 1)
                    Cabine.MoveSecondHook(false);
                else
                {
                    Cabine.MoveFirstHook(false);
                    Cabine.MoveSecondHook(false);
                }
            }
        }
    }
}