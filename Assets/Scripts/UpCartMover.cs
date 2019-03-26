using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCartMover : MonoBehaviour
{

    public CraneControl UpCart;


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Lever")
        {
            UpCart.MoveUpCart(true);
        }
    }
}