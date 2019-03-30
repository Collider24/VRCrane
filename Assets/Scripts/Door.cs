using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public GameObject Message;
    public Animator DoorAnimation;
    bool isDoorOpen = false;

    void Start()
    {
        DoorAnimation.GetComponent<Animation>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Zashel");
        if (other.tag == "Player")
        {
            Message.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (OVRInput.GetUp(OVRInput.Button.Four))
            {
                if (!isDoorOpen)
                {
                    DoorAnimation.Play("open_door");
                    isDoorOpen = true;
                }
                else
                {
                    DoorAnimation.Play("close_door");
                    isDoorOpen = false;
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Message.SetActive(false);
        }
    }
}
