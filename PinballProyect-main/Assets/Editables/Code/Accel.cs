using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour
{
    public GameObject bola;
    public GameObject directo;
    Vector3 origen, objetivo, resultado;
    bool activado;
    // Start is called before the first frame update
    private void Start()
    {
        objetivo = directo.transform.position;
    }
    private void Update()
    {
        origen = bola.transform.position;
        resultado = new Vector3(objetivo.x, 0, objetivo.z) - new Vector3(origen.x,0,origen.z);
        if (activado == true)
        {
            bola.GetComponent<Rigidbody>().AddForce(resultado * 1250000f);
        }
        else
        {
            return;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            activado = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            activado = false;
        }
    }
}
