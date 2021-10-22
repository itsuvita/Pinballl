using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenClean : MonoBehaviour
{
    public GameObject señal;
    public GameObject boton;
    public Master A;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            Destroy(other.gameObject);
            señal.SendMessage("Pase", true);
            boton.SetActive(true);
            A.B = false;
        }
    }
}