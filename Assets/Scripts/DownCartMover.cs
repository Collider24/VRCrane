using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCartMover : MonoBehaviour
{

    public CraneControl DownCart;


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Lever")
        {
            DownCart.MoveUpCart(false);
        }
    }
}