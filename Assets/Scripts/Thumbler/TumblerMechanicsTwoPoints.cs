﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumblerMechanicsTwoPoints : MonoBehaviour
{
    public int State = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.GetUp(OVRInput.Button.Four))
            {
                if (State != 0)
                {
                    State = 0;
                    transform.rotation = Quaternion.Euler(0, -135, 0);
                }
                else
                {
                    State++;
                    transform.rotation = Quaternion.Euler(0, -45, 0);
                }
            }
        }
    }
}
