using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Luz : MonoBehaviour
{
    public GameObject luz;
    bool toque = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            if (toque == false)
                {
                toque = true;
                luz.SetActive(true);
                }
            if (toque == true)
                {
                toque = false;
                luz.SetActive(false);
                }
        }
    }
}
