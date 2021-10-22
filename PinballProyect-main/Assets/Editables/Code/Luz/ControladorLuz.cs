using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorLuz : MonoBehaviour
{
    public GameObject A,B,C;
    public GameObject decenas, centenas;
    int obj = 0;

    // Update is called once per frame
    void Update()
    {
        if (obj == 3)
        {
            obj = 0;
            A.SendMessage("condicion", 1);
            B.SendMessage("condicion", 1);
            C.SendMessage("condicion", 1);
            decenas.SendMessage("Pase", 5);
            centenas.SendMessage("Pase",2);
        }
    }
    public void condicion(int other)
    {
        obj += other;
    }
}
