using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Millares : MonoBehaviour
{
    private TextMeshPro cent;
    private int num;
    public GameObject DMill;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        cent = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        cent.text = num.ToString();
        if (num >= 10 && num < 20)
        {
            num -= 10;
            DMill.SendMessage("Pase", 1);
        }
        else if (num >= 20 && num < 30)
        {
            num -= 20;
            DMill.SendMessage("Pase", 2);
        }

    }
    public void Pase(int cantidad)
    {
        num += cantidad;
    }
}
