using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject bola;
    public Vector3 spawnPosicion = new Vector3();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBola();
        }
    }

    void SpawnBola()    
    {
        Instantiate(bola, spawnPosicion, Quaternion.identity);
    }
}