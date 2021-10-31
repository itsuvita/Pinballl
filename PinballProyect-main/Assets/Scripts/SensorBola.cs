using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorBola : MonoBehaviour
{
    public GameObject a,b;
    // Update is called once per frame
    private void Start()
    {
        b = GameObject.FindGameObjectWithTag("pos");
    }
    void Update()
    {
        a = GameObject.FindGameObjectWithTag("Model");
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Model")
        {
            b.SendMessage("Pase", 3);
            a.SendMessage("Pase", 1);
        }
    }
}
