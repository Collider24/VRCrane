using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneRotation : MonoBehaviour {

    public Transform Hook;
    public Transform FirstCable;
    public Transform SecondCable;
    public float angel = 20;
    float delta;
    void Update () {
        delta = FirstCable.position.y - SecondCable.position.y;
        if (delta < 0)
        {
            Hook.rotation = Quaternion.Euler(0, 0, delta * angel);
        }
        else
        {
            Hook.rotation = Quaternion.Euler(0, 0, delta * angel);
        }
    }
}
