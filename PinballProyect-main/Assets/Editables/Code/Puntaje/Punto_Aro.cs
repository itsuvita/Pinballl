using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto_Aro : MonoBehaviour
{
    public GameObject unidades, decenas, cifras;
    private void OnCollisionEnter(Collision other)
    {
        unidades.SendMessage("Pase", 5);
        decenas.SendMessage("Pase", 3);
        cifras.SendMessage("Pase", 35);
    }
}
