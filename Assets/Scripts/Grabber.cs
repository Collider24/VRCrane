using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    public Richpoint IsGrabbed;
    public Transform Hook1;
    public Transform Hook2;
    public Transform Hook3;
    public GameObject Container;
    public Rigidbody ContainerRigidbody;
    public bool InTrigger = false;
    public bool FirstHook = false;
    public bool SecondHook = false;
    public bool ThirdHook = false;
    void Start()
    {
        ContainerRigidbody.GetComponent<Rigidbody>(); 
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hook1")
        {
            FirstHook = true;
            InTrigger = true;
            if (!IsGrabbed.Riched)
            {
                ContainerRigidbody.isKinematic = true;
                Container.transform.position = Hook1.position;
            }
            else
            {
                if (ContainerRigidbody.isKinematic)
                    ContainerRigidbody.isKinematic = false;
            }
        }
        if (other.tag == "Hook2")
        {
            SecondHook = true;
            InTrigger = true;
            if (!IsGrabbed.Riched)
            {
                ContainerRigidbody.isKinematic = true;
                Container.transform.position = Hook2.position;
            }
            else
            {
                if (ContainerRigidbody.isKinematic)
                    ContainerRigidbody.isKinematic = false;
            }
        }
        if (other.tag == "Hook3")
        {
            ThirdHook = true;
            InTrigger = true;
            if (!IsGrabbed.Riched)
            {
                ContainerRigidbody.isKinematic = true;
                Container.transform.position = Hook3.position; 
            }
            else
            {
                if (ContainerRigidbody.isKinematic)
                  ContainerRigidbody.isKinematic = false;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        InTrigger = false;
        ContainerRigidbody.isKinematic = false;
        FirstHook = false;
        SecondHook = false;
        ThirdHook = false;
    }
}