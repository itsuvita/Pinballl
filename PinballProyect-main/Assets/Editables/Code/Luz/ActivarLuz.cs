using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarLuz : MonoBehaviour
{
    public GameObject luz;
    public GameObject receptor;
    bool activo;
    bool reset = false;
    int orden = 0;
    // Start is called before the first frame update
    void Start()
    {
        activo = false;
    }
    private void Update()
    {
        if (orden == 1)
        {
            orden = 0;
            reset = true;
        }
        if (reset == true)
        {
            activo = false;
            reset = false;
            luz.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            if (activo == false)
            {
                luz.SetActive(true);
                activo = true;
                receptor.SendMessage("condicion", 1);
            }else if (activo == true)
            {
                luz.SetActive(false);
                activo = false;
                receptor.SendMessage("condicion", -1);
            }
        }
    }public void condicion(int other)
    {
        orden += other;
    }
}
