using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto_pira : MonoBehaviour
{
    public GameObject unidades, decenas;
    public GameObject cifras;
    private void OnCollisionEnter(Collision other)
    {
        unidades.SendMessage("Pase", 5);
        decenas.SendMessage("Pase", 4);
        cifras.SendMessage("Pase", 45);
    }
}
