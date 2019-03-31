using System;
using UnityEngine;
using UnityEngine.UI;
public class ScreenControl : MonoBehaviour {

    public Transform Plane;
    public Transform Hook1;
    public Transform Hook2;
    public Transform Hook3;
    public Text HeightHook1;
    public Text HeightHook2;
    public Text HeightHook3;
    public Text WeightHook1;
    public Text WeightHook2;
    public Text WeightHook3;
    public Text CommonWeight1;
    public Text CommonWeight2;
    public Text CommonWeight3;
    public Rigidbody container;
    double deltaHook1;
    double deltaHook2;
    double deltaHook3;
    public Grabber isFirst;
    public Grabber isSecond;
    public Grabber isThird;
    void Start()
    {
        container.GetComponent<Rigidbody>();
    }
    void Update()
    {
        deltaHook1 = Math.Round((Hook1.position.y - Plane.position.y), 3);
        HeightHook1.text = ("+" + deltaHook1.ToString());
        deltaHook2 = Math.Round((Hook2.position.y - Plane.position.y), 3);
        HeightHook2.text = ("+" + deltaHook2.ToString());
        deltaHook3 = Math.Round((Hook3.position.y - Plane.position.y), 3);
        HeightHook3.text = ("+" + deltaHook3.ToString());  
    }
}
