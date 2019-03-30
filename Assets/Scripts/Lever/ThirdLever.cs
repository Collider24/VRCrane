using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLever : MonoBehaviour
{
    public CraneControl Cabine;
    public TumblerMechanicsTwoPoints StateNowMoveCart;
    public TumblerMechanicsTwoPoints StateNowMoveHook;
    public TumblerMechanicsThreePoints StateNowMoveAllHooks;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
            {
                if (StateNowMoveCart.State == 0)
                    Cabine.MoveDownCart(false);
                else
                {
                    Cabine.MoveDownCart(false);
                    Cabine.MoveUpCart(false);
                }
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
            {
                if (StateNowMoveCart.State == 0)
                    Cabine.MoveDownCart(true);
                else
                {
                    Cabine.MoveDownCart(true);
                    Cabine.MoveUpCart(true);
                }
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
            {
                if (StateNowMoveHook.State == 0)
                {
                    Cabine.MoveThirdHook(true);
                }
                else
                {
                    if (StateNowMoveAllHooks.State == 0)
                    {
                        Cabine.MoveFirstHook(true);
                        Cabine.MoveThirdHook(true);
                    }
                    else if (StateNowMoveAllHooks.State == 1)
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
                if (StateNowMoveHook.State == 0)
                {
                    Cabine.MoveThirdHook(false);
                }
                else
                {
                    if (StateNowMoveAllHooks.State == 0)
                    {
                        Cabine.MoveFirstHook(false);
                        Cabine.MoveThirdHook(false);
                    }
                    else if (StateNowMoveAllHooks.State == 1)
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