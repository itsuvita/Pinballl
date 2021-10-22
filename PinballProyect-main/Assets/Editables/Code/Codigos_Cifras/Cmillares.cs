using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cmillares : MonoBehaviour
{
    private TextMeshPro cent;
    private int num;
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
    }
    public void Pase(int cantidad)
    {
        num += cantidad;
    }
}
