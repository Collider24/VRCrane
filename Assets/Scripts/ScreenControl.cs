using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScreenControl : MonoBehaviour {

    public Transform Plane;
    public Transform Hook1;
    public Transform Hook2;
    public Transform Hook3;
    public Transform UpCart;
    public Transform EndRight;
    public Text HeightHook1;
    public Text HeightHook2;
    public Text HeightHook3;
    public Text WeightHook1;
    public Text WeightHook2;
    public Text WeightHook3;
    public Text LenthCart;
    public Text LenthHook;
    public Text CommonWeight1;
    public Text CommonWeight2;
    public Text CommonWeight3;
    public Text PowerA1;
    public Text PowerA2;
    public Text PowerA3;
    public Text PowerA4;
    public Text PowerA5;
    public Text PowerA1H;
    public Text PowerA2H;
    public Text PowerA3H;
    public Text PowerA4H;
    public Text PowerA5H;
    float forRand, forRandH;
    int i = 0;
    public Rigidbody container;
    double deltaHook1;
    double deltaHook2;
    double deltaHook3;
    double deltaHook4;
    double deltaUpCart;
    double StartHookPosition;
    public Grabber isFirst;
    public Grabber isSecond;
    public Grabber isThird;
    public FirstLever isCartMove;
    public FirstLever isHookMove;
    public FirstLever isThirdHookMove;
    UnityEngine.Random rand;

    void Start()
    {
        container.GetComponent<Rigidbody>();
        StartHookPosition = Hook1.position.y;
    }
    void Update()
    {
        deltaHook1 = Math.Round((Hook1.position.y - Plane.position.y), 3);
        HeightHook1.text = ("+" + deltaHook1.ToString());
        deltaHook2 = Math.Round((Hook2.position.y - Plane.position.y), 3);
        HeightHook2.text = ("+" + deltaHook2.ToString());
        deltaHook3 = Math.Round((Hook3.position.y - Plane.position.y), 3);
        HeightHook3.text = ("+" + deltaHook3.ToString());  
        if (container)
        {
            if (isFirst.FirstHook)
            {
                WeightHook1.text = ("+" + container.mass.ToString());
            }
            if (isSecond.SecondHook)
            {
                WeightHook2.text = ("+" + container.mass.ToString());
            }
            if (isThird.ThirdHook)
            {
                WeightHook3.text = ("+" + container.mass.ToString());
            }
            if (isFirst.FirstHook || isSecond.SecondHook || isThird.ThirdHook)
            {
                CommonWeight1.text = ("+" + container.mass.ToString());
                CommonWeight2.text = ("+" + container.mass.ToString());
                CommonWeight3.text = ("+" + container.mass.ToString());
            }
            if (!isFirst.FirstHook)
            {
                WeightHook1.text = ("+0.000");
            }
            if (!isSecond.SecondHook)
            {
                WeightHook2.text = ("+0.000");
            }
            if (!isThird.ThirdHook)
            {
                WeightHook3.text = ("+0.000");
            }
            if (!isFirst.FirstHook && !isSecond.SecondHook && !isThird.ThirdHook)
            {
                CommonWeight1.text = ("+0.000");
                CommonWeight2.text = ("+0.000");
                CommonWeight3.text = ("+0.000");
            }
        }
        deltaUpCart = Math.Round((UpCart.position.z - EndRight.position.z), 3);
        LenthCart.text = ("+" + deltaUpCart.ToString());
        deltaHook4 = Math.Round((StartHookPosition - Hook1.position.y), 3);
        LenthHook.text = ("+" + deltaHook4.ToString());
        if (isCartMove.UpCartMove)
        {
            
            i++;
            if (i%60==0)
            {
                forRand = UnityEngine.Random.Range(0.020f, 0.065f);
                PowerA4.text = ("+" + (forRand).ToString());
                forRandH = UnityEngine.Random.Range(0.020f, 0.065f);
                PowerA4H.text = ("+" + (forRandH).ToString());
            }
        }
        if (isCartMove.Hook1Move || isThirdHookMove.Hook1Move)
        {

            i++;
            if (i % 60 == 0)
            {
                
                forRand = UnityEngine.Random.Range(0.020f, 0.065f);
                PowerA5.text = ("+" + (forRand).ToString());
                PowerA1.text = ("+" + (forRand).ToString());
                forRandH = UnityEngine.Random.Range(0.020f, 0.065f);
                PowerA5H.text = ("+" + (forRandH).ToString());
                PowerA1H.text = ("+" + (forRandH).ToString());
            }
        }
        if (isCartMove.Hook2Move || isThirdHookMove.Hook2Move)
        {

            i++;
            if (i % 60 == 0)
            {
                forRand = UnityEngine.Random.Range(0.020f, 0.065f);
                PowerA2.text = ("+" + (forRand).ToString());
                forRandH = UnityEngine.Random.Range(0.020f, 0.065f);
                PowerA2H.text = ("+" + (forRandH).ToString());
            }
        }
        if (isCartMove.Hook3Move || isThirdHookMove.Hook3Move)
        {

            i++;
            if (i % 60 == 0)
            {
                forRand = UnityEngine.Random.Range(0.020f, 0.065f);
                PowerA3.text = ("+" + (forRand).ToString());
                forRandH = UnityEngine.Random.Range(0.020f, 0.065f);
                PowerA3H.text = ("+" + (forRandH).ToString());
            }
        }
    }
}
