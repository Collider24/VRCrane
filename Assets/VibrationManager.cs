using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationManager : MonoBehaviour
{
    public static VibrationManager singleton;
    public AudioClip vibrationsound;
    void Start()
    {
        if (singleton && singleton != this)
            Destroy(this);
        else
            singleton = this;
    }   
    public void TriggerVibration(OVRInput.Controller controller)
    {
        OVRHapticsClip clip = new OVRHapticsClip(vibrationsound);
        if ((OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft)) || (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight)))
            OVRHaptics.RightChannel.Preempt(clip);
    }

}
