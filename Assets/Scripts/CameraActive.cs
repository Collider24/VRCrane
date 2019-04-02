using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActive : MonoBehaviour
{

    public CraneControl Screen;
    public bool Active = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            Screen.ScreenActive(Active);
            Active = !Active;
        }
    }

}
