using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneControl : MonoBehaviour
{
    #region Variable
    public Transform Crane;
    public Transform EndPointLeftCrane;
    public Transform EndPointRightCrane;
    public Transform UpCart;
    public Transform EndPointLeftUpCart;
    public Transform EndPointRightUpCart;
    public Transform DownCart;
    public Transform EndPointLeftDownCart;
    public Transform EndPointRightDownCart;
    public Transform EndPointCalibrateFirstHookLeft;
    public Transform EndPointCalibrateFirstHookRight;
    public Transform EndPointCalibrateSecondHookLeft;
    public Transform EndPointCalibrateSecondHookRight;
    public Transform EndPointCalibrateThirdHookLeft;
    public Transform EndPointCalibrateThirdHookRight;
    public Transform EndPointCalibrateSecondMainHookLeft;
    public Transform EndPointCalibrateSecondMainHookRight;
    public Transform Hook1;
    public Transform Hook2;
    public Transform Hook3;
    public Transform Hook11;
    public Transform Hook12;
    public Transform Hook21;
    public Transform Hook22;
    public Transform Hook31;
    public Transform Hook32;
    public Transform MainHook1;
    public Transform MainHook2;
    public Transform MainHook3;
    public Transform HookPoint1;
    public Transform HookPoint2;
    public Transform HookPoint3;
    public Transform RotatePoint1;
    public Transform RotatePoint2;
    public Transform RotatePoint3;
    public GameObject ScreenCanvas;
    public GameObject ScreenPlane;
    public GameObject ScreenCamera;
    float StartX;
    float EndX;
    float delta;
    bool direction;
    public float SpeedUpCart = 10;
    public float SpeedDownCart = 10;
    public float SpeedAllCrane = 10;
    public float SpeedHook1 = 1;
    public float SpeedHook2 = 1;
    public float SpeedHook3 = 1;
    float value;
    float counter1;
    float counter2;
    float counter3;
    bool started;
    #endregion

    void Start()
    {
        counter1 = Hook11.localScale.y;
        counter2 = Hook21.localScale.y;
        counter3 = Hook31.localScale.y;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = true;
            MoveUpCart(direction);
        }
        if(Input.GetKey(KeyCode.S))
        {
            direction = false;
            MoveUpCart(direction);
        }
        if (Input.GetKey(KeyCode.I))
        {
            direction = true;
            MoveDownCart(direction);
        }
        if (Input.GetKey(KeyCode.K))
        {
            direction = false;
            MoveDownCart(direction);
        }
        if (Input.GetKey(KeyCode.T))
        {
            direction = true;
            MoveFirstHook(direction);
        }
        if (Input.GetKey(KeyCode.G))
        {
            direction = false;
            MoveFirstHook(direction);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            direction = true;
            MoveSecondHook(direction);
        }
        if (Input.GetKey(KeyCode.H))
        {
            direction = false;
            MoveSecondHook(direction);
        }
        if (Input.GetKey(KeyCode.U))
        {
            direction = true;
            MoveThirdHook(direction);
        }
        if (Input.GetKey(KeyCode.J))
        {
            direction = false;
            MoveThirdHook(direction);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = false;
            MoveAllCrane(direction);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction = true;
            MoveAllCrane(direction);
        }
        if (Input.GetKey(KeyCode.P))
        {
            direction = true;
            CalibrateSecondHook(direction);
        }
        if (Input.GetKey(KeyCode.O))
        {
            direction = false;
            CalibrateSecondHook(direction);
        }
    }
    public void StartCrane (bool a)
    {
        started = a;
    }
    public void MoveUpCart(bool a)
    {
        if (started)
        {
            if (!a)
            {
                Hook11.position = Vector3.MoveTowards(Hook11.position, EndPointCalibrateFirstHookRight.position, Time.deltaTime * SpeedUpCart);

            }
            else
            {
                UpCart.position = Vector3.MoveTowards(UpCart.position, EndPointRightUpCart.position, Time.deltaTime * SpeedUpCart);
            }
        }
    }
    public void MoveDownCart(bool a)
    {
        if (started)
        {
            if (!a)
            {
                DownCart.position = Vector3.MoveTowards(DownCart.position, EndPointLeftDownCart.position, Time.deltaTime * SpeedDownCart);
            }
            else
            {
                DownCart.position = Vector3.MoveTowards(DownCart.position, EndPointRightDownCart.position, Time.deltaTime * SpeedDownCart);
            }
        }
    }
    public void MoveFirstHook (bool a)
    {
        if (started)
        {
            if (!a)
            {

                value = SpeedHook1 * 0.1f;
                if (counter1 < 26)
                {
                    Hook11.localScale += new Vector3(0, value, 0);
                    Hook12.localScale += new Vector3(0, value, 0);
                    counter1 += SpeedHook1 * 0.1f;
                    MainHook1.position = new Vector3(HookPoint1.position.x, HookPoint1.position.y, HookPoint1.position.z);
                }
            }
            if (a)
            {

                value = SpeedHook1 * 0.1f;
                if (counter1 > 1)
                {
                    Hook11.localScale -= new Vector3(0, value, 0);
                    Hook12.localScale -= new Vector3(0, value, 0);
                    counter1 -= SpeedHook1 * 0.1f;
                    MainHook1.position = new Vector3(HookPoint1.position.x, HookPoint1.position.y, HookPoint1.position.z);
                }
            }
        }
    }
    public void MoveSecondHook(bool a)
    {
        if (started)
        {
            if (!a)
            {

                value = SpeedHook2 * 0.1f;
                if (counter2 < 26)
                {
                    Hook21.localScale += new Vector3(0, value, 0);
                    Hook22.localScale += new Vector3(0, value, 0);
                    counter2 += SpeedHook2 * 0.1f;
                    MainHook2.position = new Vector3(HookPoint2.position.x, HookPoint2.position.y, HookPoint2.position.z);
                    EndPointCalibrateSecondMainHookLeft.position = new Vector3 (EndPointCalibrateSecondMainHookLeft.position.x, HookPoint2.position.y, EndPointCalibrateSecondMainHookLeft.position.z);
                    EndPointCalibrateSecondMainHookLeft.position = new Vector3(EndPointCalibrateSecondMainHookRight.position.x, HookPoint2.position.y, EndPointCalibrateSecondMainHookRight.position.z);
                }
            }
            if (a)
            {

                value = SpeedHook2 * 0.1f;
                if (counter2 > 1)
                {
                    Hook21.localScale -= new Vector3(0, value, 0);
                    Hook22.localScale -= new Vector3(0, value, 0);
                    counter2 -= SpeedHook2 * 0.1f;
                    MainHook2.position = new Vector3(HookPoint2.position.x, HookPoint2.position.y, HookPoint2.position.z);
                    EndPointCalibrateSecondMainHookLeft.position = new Vector3(EndPointCalibrateSecondMainHookLeft.position.x, HookPoint2.position.y, EndPointCalibrateSecondMainHookLeft.position.z);
                    EndPointCalibrateSecondMainHookLeft.position = new Vector3(EndPointCalibrateSecondMainHookRight.position.x, HookPoint2.position.y, EndPointCalibrateSecondMainHookRight.position.z);
                }
            }
        }
    }
    public void MoveThirdHook(bool a)
    {
        if (started)
        {
            if (!a)
            {

                value = SpeedHook3 * 0.1f;
                if (counter3 < 26)
                {
                    Hook31.localScale += new Vector3(0, value, 0);
                    Hook32.localScale += new Vector3(0, value, 0);
                    counter3 += SpeedHook3 * 0.1f;
                    MainHook3.position = new Vector3(HookPoint3.position.x, HookPoint3.position.y, HookPoint3.position.z);
                }
            }
            if (a)
            {

                value = SpeedHook3 * 0.1f;
                if (counter3 > 1)
                {
                    Hook31.localScale -= new Vector3(0, value, 0);
                    Hook32.localScale -= new Vector3(0, value, 0);
                    counter3 -= SpeedHook3 * 0.1f;
                    MainHook3.position = new Vector3(HookPoint3.position.x, HookPoint3.position.y, HookPoint3.position.z);
                }
            }
        }
    }
    public void CalibrateSecondHook(bool a)
    {
        if (started)
        {
            MainHook2.position = new Vector3(HookPoint2.position.x, HookPoint2.position.y, HookPoint2.position.z);
            if (!a)
            { 
                Hook2.position = Vector3.MoveTowards(Hook2.position, EndPointCalibrateSecondHookRight.position, Time.deltaTime * SpeedUpCart);
                MainHook2.position = Vector3.MoveTowards(MainHook2.position, EndPointCalibrateSecondMainHookRight.position, Time.deltaTime * SpeedUpCart);
            }
            else
            {
                Hook2.position = Vector3.MoveTowards(Hook2.position, EndPointCalibrateSecondHookLeft.position, Time.deltaTime * SpeedUpCart);
                MainHook2.position = Vector3.MoveTowards(MainHook2.position, EndPointCalibrateSecondMainHookLeft.position, Time.deltaTime * SpeedUpCart);
            }
        }
    }
    /*public void RotatePointZ3(bool a)
    {
        if (started)
        {
            if(a)
            {
                RotatePoint3.position += new Vector3(0, 0.1f, 0);
            }
            else
            {
                RotatePoint3.position += new Vector3(0, -0.1f, 0);
            }
        }
    } */
    public void MoveAllCrane(bool a) {
        if (started)
        {
            if (!a)
            {
                StartX = Crane.position.x;
                Crane.position = Vector3.MoveTowards(Crane.position, EndPointLeftCrane.position, Time.deltaTime * SpeedAllCrane);
                EndX = Crane.position.x;
                delta = StartX - EndX;
                MoveAll(delta);
            }
            else
            {
                StartX = Crane.position.x;
                Crane.position = Vector3.MoveTowards(Crane.position, EndPointRightCrane.position, Time.deltaTime * SpeedAllCrane);
                EndX = Crane.position.x;
                delta = StartX - EndX;
                MoveAll(delta);
            }
        }
    }
    public void MoveAll (float r)
    {
        if (started)
        {
            UpCart.position = new Vector3(UpCart.position.x - delta, UpCart.position.y, UpCart.position.z);
            EndPointLeftUpCart.position = new Vector3(EndPointLeftUpCart.position.x - delta, EndPointLeftUpCart.position.y, EndPointLeftUpCart.position.z);
            EndPointRightUpCart.position = new Vector3(EndPointRightUpCart.position.x - delta, EndPointRightUpCart.position.y, EndPointRightUpCart.position.z);
            DownCart.position = new Vector3(DownCart.position.x - delta, DownCart.position.y, DownCart.position.z);
            EndPointLeftDownCart.position = new Vector3(EndPointLeftDownCart.position.x - delta, EndPointLeftDownCart.position.y, EndPointLeftDownCart.position.z);
            EndPointRightDownCart.position = new Vector3(EndPointRightDownCart.position.x - delta, EndPointRightDownCart.position.y, EndPointRightDownCart.position.z);
        }
    }
    public void ScreenActive (bool active)
    {

            ScreenPlane.SetActive(active);
            ScreenCanvas.SetActive(active);
            ScreenCamera.SetActive(!active);
    }
}