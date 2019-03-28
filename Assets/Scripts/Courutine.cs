using UnityEngine;
using System.Collections;

public class Courutine : MonoBehaviour
{


    void Start()
    {
        
    }

    IEnumerator TestCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.1f);
            
        }
    }
}