using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto_Eje : MonoBehaviour
{
    public GameObject unidades, decenas,cifras;
    private void OnCollisionEnter(Collision other)
    {
        unidades.SendMessage("Pase", 5);
        decenas.SendMessage("Pase", 2);
        cifras.SendMessage("Pase", 25);
    }
}
