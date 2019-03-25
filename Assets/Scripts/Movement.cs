using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public Transform EndPointLeft;
    public Transform EndPointRight;
    public Transform EndPointUp;
    public Transform EndPointDown;
    public Transform EndPoint1;
    public Transform EndPoint2;
    public GameObject kabina;
    public GameObject Axis;
    public GameObject Stoiki;
    public GameObject Stoika1;
    public GameObject Stoika2;
    public float speed = 1.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        
        if (Input.GetKey(KeyCode.S))
        {
            kabina.transform.position = Vector3.MoveTowards(kabina.transform.position, EndPointLeft.position, Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            kabina.transform.position = Vector3.MoveTowards(kabina.transform.position, EndPointRight.position, Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Axis.transform.position = Vector3.MoveTowards(Axis.transform.position, EndPointUp.position, Time.deltaTime * speed);
            kabina.transform.position = new Vector3(kabina.transform.position.x, Axis.transform.position.y, kabina.transform.position.z);
            EndPointLeft.position = new Vector3(EndPointLeft.position.x, Axis.transform.position.y, EndPointLeft.position.z);
            EndPointRight.position = new Vector3(EndPointRight.position.x, Axis.transform.position.y, EndPointRight.position.z);
        }
        if (Input.GetKey(KeyCode.E))
        {
            Axis.transform.position = Vector3.MoveTowards(Axis.transform.position, EndPointDown.position, Time.deltaTime * speed);
            kabina.transform.position = new Vector3(kabina.transform.position.x, Axis.transform.position.y, kabina.transform.position.z);
            EndPointLeft.position = new Vector3(EndPointLeft.position.x, Axis.transform.position.y, EndPointLeft.position.z);
            EndPointRight.position = new Vector3(EndPointRight.position.x, Axis.transform.position.y, EndPointRight.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Stoiki.transform.position = Vector3.MoveTowards(Stoiki.transform.position, EndPoint1.position, Time.deltaTime * speed);
            Axis.transform.position = new Vector3(Axis.transform.position.x, Axis.transform.position.y, Stoiki.transform.position.z);
            kabina.transform.position = new Vector3(kabina.transform.position.x, kabina.transform.position.y, Stoiki.transform.position.z);
            EndPointLeft.position = new Vector3(Stoika1.transform.position.x, Axis.transform.position.y, Stoika1.transform.position.z);
            EndPointRight.position = new Vector3(Stoika2.transform.position.x, Axis.transform.position.y, Stoika2.transform.position.z);
            EndPointUp.position = new Vector3(EndPointUp.transform.position.x, EndPointUp.transform.position.y, Stoiki.transform.position.z);
            EndPointDown.position = new Vector3(EndPointDown.transform.position.x, EndPointDown.transform.position.y, Stoiki.transform.position.z);

        }
        if (Input.GetKey(KeyCode.D))
        {
            Stoiki.transform.position = Vector3.MoveTowards(Stoiki.transform.position, EndPoint2.position, Time.deltaTime * speed);
            Axis.transform.position = new Vector3(Axis.transform.position.x, Axis.transform.position.y, Stoiki.transform.position.z);
            kabina.transform.position = new Vector3(kabina.transform.position.x, kabina.transform.position.y, Stoiki.transform.position.z);
            EndPointLeft.position = new Vector3(Stoika1.transform.position.x, Axis.transform.position.y, Stoika1.transform.position.z);
            EndPointRight.position = new Vector3(Stoika2.transform.position.x, Axis.transform.position.y, Stoika2.transform.position.z);
            EndPointUp.position = new Vector3(EndPointUp.transform.position.x, EndPointUp.transform.position.y, Stoiki.transform.position.z);
            EndPointDown.position = new Vector3(EndPointDown.transform.position.x, EndPointDown.transform.position.y, Stoiki.transform.position.z);
        }
    }
}
