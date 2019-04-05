using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabUpHook : MonoBehaviour {
    public Transform Hook1;
    public Transform Hook2;
    public Transform HookCenter;
    public Hook1Grab isGrab1;
    public Hook2Grab isGrab2;
    public Transform Container;
    float delta;
    public float Angel = 20;
    public Hook1Grab IsIn1;
    public Hook1Grab IsIn2;
    public Rigidbody ContainerRigidbody;
    public Richpoint IsGrabbed;
    void Start()
    {
        ContainerRigidbody.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (isGrab1.Grabbed && isGrab2.Grabbed)
        {
            if (!IsGrabbed.Riched)
            {
                ContainerRigidbody.useGravity = false;
                ContainerRigidbody.isKinematic = true;
                Container.position = HookCenter.position;
                delta = Hook1.position.y - Hook2.position.y;
                if (delta < 0)
                {
                    Container.rotation = Quaternion.Euler(0, 0, delta * Angel);
                }
                else
                {
                    Container.rotation = Quaternion.Euler(0, 0, delta * Angel);
                }
            }
            else
            {
                ContainerRigidbody.useGravity = true;
                ContainerRigidbody.isKinematic = false;
            }
        }
    }
}
