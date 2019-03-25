using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class track_pos : MonoBehaviour
{
    public Transform Plane;
    public Text Pos;
    double i;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i = Math.Round((transform.position.y - Plane.transform.position.y), 3);
        Pos.text = ("+" + i.ToString());
        
    }
}
