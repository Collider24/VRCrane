using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumblerMechanics : MonoBehaviour {

    public CraneControl Thumbler;
    public int Position = 0;
    
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.GetUp(OVRInput.Button.Four))
            {
                Position++;
                if (Position != 2)
                {
                    transform.rotation *= Quaternion.Euler(0, 45, 0);
                }
                else
                {
                    Position = 0;
                    transform.rotation = Quaternion.Euler(0, 45, 0);
                }
            }

        }
    }

}
