using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {
    public GameObject Light;
    bool LightActive = false;
    void OnTriggerEnter(Collider other)
    {
        if (OVRInput.GetUp(OVRInput.Button.Four))
        {
            LightActive = !LightActive;
            Light.SetActive(LightActive);
            if (LightActive)
                transform.rotation = Quaternion.Euler(0, 45, 0);
            else
                transform.rotation = Quaternion.Euler(0, -45, 0);
        }
    }
}
