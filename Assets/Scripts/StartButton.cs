﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public CraneControl Button;
    public GameObject LightGreen;
    public GameObject LightRed;
    public GameObject Screen;
    public bool Done;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            StartCoroutine(TestCoroutine());
        }
    }
    IEnumerator TestCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.1f);
            LightGreen.SetActive(true);
            for (int i =0; i<3; i++)
            {
                yield return new WaitForSeconds(0.5f);
                LightGreen.SetActive(true);
                yield return new WaitForSeconds(0.5f);
                LightGreen.SetActive(false);
            }
            yield return new WaitForSeconds(0.5f);
            LightGreen.SetActive(true);
            Button.StartCrane(true);
            LightRed.SetActive(false);
            Button.StartCrane(true);
            LightRed.SetActive(false);
            Done = true;
            Screen.SetActive(true);
            break;
        }
    }
    void OnTriggerExit(Collider other)
    { 
        StopCoroutine(TestCoroutine());
        Screen.SetActive(false);
        if (!Done)
        {
            LightGreen.SetActive(false);
            Button.StartCrane(false);
            LightRed.SetActive(true);
        }
    }
}
