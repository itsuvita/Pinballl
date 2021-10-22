using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Decenas : MonoBehaviour
{
    private TextMeshPro dec;
    private int decenas;
    public GameObject centenas;
    // Start is called before the first frame update
    void Start()
    {
        decenas = 0;
        dec = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        dec.text = decenas.ToString();
        if (decenas >= 10 && decenas < 20)
        {
            decenas -= 10;
            centenas.SendMessage("Pase", 1);
        }
        else if (decenas >= 20 && decenas < 30)
        {
            decenas -= 20;
            centenas.SendMessage("Pase", 2);
        }

    }
    public void Pase (int cantidad)
    {
        decenas += cantidad;
    }
}
