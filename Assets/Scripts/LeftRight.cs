using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    public CraneControl Cabine;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hand")
        {
            if(OVRInput.GetUp(OVRInput.Button.One))
            {
                Cabine.MoveUpCart(false);
            }
            else
            {
                Cabine.MoveUpCart(true);
            }
        }
    }
}

