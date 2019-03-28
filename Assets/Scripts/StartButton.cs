using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public CraneControl Button;
    public GameObject LightGreen;
    public GameObject LightRed;
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
            break;
        }
    }
    void OnTriggerExit(Collider other)
    {
        StopCoroutine(TestCoroutine());
        Button.StartCrane(false);
        LightGreen.SetActive(false);
        LightRed.SetActive(true);
    }
}
