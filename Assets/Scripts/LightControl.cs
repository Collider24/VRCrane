using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public int State = 0;
    public GameObject Light;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (OVRInput.GetUp(OVRInput.Button.Four))
            {
                State = (State  + 1) % 2;
                if (State == 1)
                {
                    transform.rotation = Quaternion.Euler(0, -45, 0);
                    Light.SetActive(true);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, -135, 0);
                    Light.SetActive(false);
                }
            }
        }
    }
}
