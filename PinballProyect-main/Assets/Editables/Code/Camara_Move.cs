using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Move : MonoBehaviour
{
    public bool activ;
    public GameObject B;
    public SensorCam A;
    // Start is called before the first frame update
    void Start()
    {
        A = FindObjectOfType<SensorCam>();
    }

    // Update is called once per frame
    void Update()
    {
        activ = A.activo;
        if (activ == true)
        {
            ReposicionCamara();
        }
        else
        {
            return;
        }
    }
    private void ReposicionCamara()
    {
    }
}
