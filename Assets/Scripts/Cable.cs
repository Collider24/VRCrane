using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{

    public float Speed = 1;
    float value;
    float counter = 1;

    void Start()
    {
        counter = transform.localScale.y; ;
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.G))
        {
            
            value = Speed * 0.1f;
            if (counter < 26)
            {
                transform.localScale += new Vector3(0, value, 0);
                counter+=Speed*0.1f;
            }
        }
        if (Input.GetKey(KeyCode.T))
        {

            value = Speed * 0.1f;
            if (counter > 1)
            {
                transform.localScale -= new Vector3(0, value, 0);
                counter -= Speed * 0.1f;
            }
        }
    }
}