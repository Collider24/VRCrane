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
    public bool FirstContainer = false;
    public bool SecondContainer = false;
    public bool ThirdContainer = false;
    public bool InTrigger = false;
    void Start()
    {
        ContainerRigidbody.GetComponent<Rigidbody>(); 
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hook1")
        {
            InTrigger = true;
            FirstContainer = true;
            if (IsGrabbed.Grabbed)
            {
                ContainerRigidbody.isKinematic = true;
                Container.transform.position = Hook1.position; 
            }
            else
            {
                ContainerRigidbody.isKinematic = false;
            }
        }
        else if(other.tag == "Hook2")
        {
            InTrigger = true;
            SecondContainer = true;
            if (IsGrabbed.Grabbed)
            {
                ContainerRigidbody.isKinematic = true;
                Container.transform.position = Hook2.position;
            }
            else
            {
                ContainerRigidbody.isKinematic = false;
            }
        }
        else if(other.tag == "Hook3")
        {
            InTrigger = true;
            ThirdContainer = true;
            if (IsGrabbed.Grabbed)
            {
                ContainerRigidbody.isKinematic = true;
                Container.transform.position = Hook3.position;
            }
            else
            {
                ContainerRigidbody.isKinematic = false;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        InTrigger = false;
        FirstContainer = false;
        SecondContainer = false;
        ThirdContainer = false;
    }
}