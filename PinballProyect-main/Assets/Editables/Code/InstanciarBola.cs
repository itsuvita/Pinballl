using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarBola : MonoBehaviour
{
    public GameObject bola,fuerza;
    public Transform Origen;
    Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = Origen.position;
    }

    // Update is called once per frame
    public void SpawnBola()
    {
        Instantiate(bola, spawnPos, Quaternion.identity);
        gameObject.SetActive(false);
        fuerza.SetActive(true);
    }
    
}
