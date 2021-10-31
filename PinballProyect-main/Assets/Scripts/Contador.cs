using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public int cifras, alea, i;
    bool activo = false,iniciado=false;
    public GameObject maid,maid2;
    // Start is called before the first frame update
    void Start()
    {
        cifras = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (iniciado == true)
        {
            return;
        }
        else
        {
            if (cifras >= 2000)
            {
                cifras -= 2000;
                activo = true;
                iniciado = true;
            }
        }
        if (activo == true)
        {
            for(i=1; i<=10; i++)
            {
                alea = Random.Range(1,3);
            }
            if (alea == 1)
            {
                maid.SetActive(true);
            }else if(alea == 2)
            {
                maid2.SetActive(true);
            }
            activo = false;
        }if (activo == false)
        {
            i = 0;
        }

    }
    public void Pase(int mensajero)
    {
        cifras += mensajero;
    }
    public void Maid(bool sola)
    {
        iniciado = sola;
    }
}
