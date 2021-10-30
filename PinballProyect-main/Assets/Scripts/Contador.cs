using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public int cifras, mensajero;
    public GameObject maid;
    // Start is called before the first frame update
    void Start()
    {
        cifras = 0;
        mensajero = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cifras >= 2500)
        {
            cifras -= 2500;
            maid.SetActive(true);
        }
    }
    public void Pase(int mensajero)
    {
        cifras += mensajero;
    }
}
