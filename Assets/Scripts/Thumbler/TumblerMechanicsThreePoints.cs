using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumblerMechanicsThreePoints : MonoBehaviour
{
    public int State = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.GetUp(OVRInput.Button.Four))
            {
                State = (State + 1) % 3;
                transform.rotation = Quaternion.Euler(transform.rotation.x, 45*State + 45, transform.rotation.z);
            }

        }
    }
}