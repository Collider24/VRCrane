using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumblerMechanics : MonoBehaviour {

    public CraneControl Thumbler;
    
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.GetUp(OVRInput.Button.One))
            {
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            if (OVRInput.GetUp(OVRInput.Button.Two))
            {
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
        }
    }

}
