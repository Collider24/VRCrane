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
                State++;
                if (State != 2)
                {
                    transform.rotation *= Quaternion.Euler(0, 45, 0);
                }
                else
                {
                    State = 0;
                    transform.rotation = Quaternion.Euler(0, -45, 0);
                }
            }

        }
    }

}
