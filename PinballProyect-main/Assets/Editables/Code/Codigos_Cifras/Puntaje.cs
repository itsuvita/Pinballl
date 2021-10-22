using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private TextMeshPro Unidades;
    private int cifra;
    public GameObject decenas;
    public GameObject centenas;
    // Start is called before the first frame update
    void Start()
    {
        cifra = 0;
        Unidades = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        Unidades.text = cifra.ToString();
        if(cifra>=10 && cifra<20)
        {
            cifra -= 10;
            decenas.SendMessage("Pase", 1);
        }else if(cifra >= 20 && cifra < 30)
        {
            cifra -= 20;
            decenas.SendMessage("Pase", 2);
        }
    }
    public void Pase(int cantidad)
    {
        cifra += cantidad;
    }

}
