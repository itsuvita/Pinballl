using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto_Barra : MonoBehaviour
{
    public GameObject unidades, decenas,cifras;
    private void OnCollisionEnter(Collision other)
    {
        unidades.SendMessage("Pase", 5);
        decenas.SendMessage("Pase", 1);
        cifras.SendMessage("Pase", 15);
    }
}
