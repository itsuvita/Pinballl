using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorCam : MonoBehaviour
{
    public bool activo;
    // Start is called before the first frame update
    void Start()
    {
        activo = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            activo = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            activo = false;
        }
    }
}
