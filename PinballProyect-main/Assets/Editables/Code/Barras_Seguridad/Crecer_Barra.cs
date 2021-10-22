using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crecer_Barra : MonoBehaviour
{
    public float A, B;
    // Start is called before the first frame update
    void Start()
    {
        A = 0;
        B = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (B > A)
        {
            A += Time.deltaTime;
            gameObject.transform.localScale = gameObject.transform.localScale + new Vector3(4f * Time.deltaTime, 1.5f * Time.deltaTime, 5f * Time.deltaTime);
        }else
        {
            return;
        }
    }
}
