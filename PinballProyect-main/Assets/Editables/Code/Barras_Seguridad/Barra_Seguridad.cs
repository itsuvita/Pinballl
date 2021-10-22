using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_Seguridad : MonoBehaviour
{
    bool coli=false;
    float A=1f, B = 0;
    private void Update()
    {
        if (coli == true)
        {
            if (A > B)
            {
                B += Time.deltaTime;
                gameObject.transform.localScale = gameObject.transform.localScale - new Vector3(2.5f * Time.deltaTime, 1f * Time.deltaTime, 5f * Time.deltaTime);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        coli = true;
    }
}
