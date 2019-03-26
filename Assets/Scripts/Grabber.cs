using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour {

    public Transform Container;
    bool fix;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Container")
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                fix = true;
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                fix = false;
            }
            if (fix)
            {
                Container.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
        }
    }
}
