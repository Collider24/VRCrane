using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLever : MonoBehaviour
{
    public CraneControl Cabine;
    public TumblerMechanicsTwoPoints StateNowCarts;
    public TumblerMechanicsTwoPoints StateNowHooks;
    public TumblerMechanicsThreePoints StateNowFirstSecondHooks;
    public bool UpCartMove = false;
    public bool Hook1Move = false;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if(OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
            {
                UpCartMove = true;
                Hook1Move = false;
                if (StateNowCarts.State == 0)
                    Cabine.MoveUpCart(false);
                else
                {
                    Cabine.MoveDownCart(false);
                    Cabine.MoveUpCart(false);
                }
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
            {
                UpCartMove = true;
                Hook1Move = false;
                if (StateNowCarts.State == 0)
                    Cabine.MoveUpCart(true);
                else
                {
                    Cabine.MoveDownCart(true);
                    Cabine.MoveUpCart(true);
                }
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
            {
                UpCartMove = false;
                Hook1Move = true;
                if (StateNowHooks.State == 0)
                {
                    if (StateNowFirstSecondHooks.State == 0)
                        Cabine.MoveFirstHook(true);
                    else if (StateNowFirstSecondHooks.State == 1)
                        Cabine.MoveSecondHook(true);
                    else
                    {
                        Cabine.MoveFirstHook(true);
                        Cabine.MoveSecondHook(true);
                    }
                }
                else
                {
                    if (StateNowFirstSecondHooks.State == 0)
                    {
                        Cabine.MoveFirstHook(true);
                        Cabine.MoveThirdHook(true);
                    }
                    else if (StateNowFirstSecondHooks.State == 1)
                    {
                        Cabine.MoveSecondHook(true);
                        Cabine.MoveThirdHook(true);
                    }
                    else
                    {
                        Cabine.MoveFirstHook(true);
                        Cabine.MoveSecondHook(true);
                        Cabine.MoveThirdHook(true);
                    }
                }
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
            {
                UpCartMove = false;
                Hook1Move = true;
                if (StateNowHooks.State == 0)
                {
                    if (StateNowFirstSecondHooks.State == 0)
                        Cabine.MoveFirstHook(false);
                    else if (StateNowFirstSecondHooks.State == 1)
                        Cabine.MoveSecondHook(false);
                    else
                    {
                        Cabine.MoveFirstHook(false);
                        Cabine.MoveSecondHook(false);
                    }
                }
                else
                {
                    if (StateNowFirstSecondHooks.State == 0)
                    {
                        Cabine.MoveFirstHook(false);
                        Cabine.MoveThirdHook(false);
                    }
                    else if (StateNowFirstSecondHooks.State == 1)
                    {
                        Cabine.MoveSecondHook(false);
                        Cabine.MoveThirdHook(false);
                    }
                    else
                    {
                        Cabine.MoveFirstHook(false);
                        Cabine.MoveSecondHook(false);
                        Cabine.MoveThirdHook(false);
                    }
                }
            }
        }
    }
}