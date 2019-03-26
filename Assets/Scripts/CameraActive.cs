using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActive : MonoBehaviour
{

    public CraneControl Screen;
    private bool active = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            Screen.ScreenActive(active);
            active = !active;
        }
    }
}
