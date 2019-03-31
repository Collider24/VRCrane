using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    public Grabbutton IsGrabbed;
    public Transform Hook1;
    public Transform Hook2;
    public Transform Hook3;
    public GameObject Container;
    public Rigidbody ContainerRigidbody;
    public bool InTrigger = false;
    void Start()
    {
        ContainerRigidbody.GetComponent<Rigidbody>(); 
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hook3")
        {
            InTrigger = true;
            if (IsGrabbed.Grabbed)
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
    }
}