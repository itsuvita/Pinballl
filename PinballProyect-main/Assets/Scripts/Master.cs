using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public GameObject bola;
    public GameObject alfa;
    Vector3 spawnPos;
    public bool B = false;

    void Start()
    {
        spawnPos = alfa.transform.position;
    }

    void Update()
    {

#if UNITY_ANDROID
        if (B == false)
        {
            float ancho = Screen.width;
            float alto = Screen.height;
            for (int i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    if (Input.GetTouch(i).position.x > ancho / 2 && Input.GetTouch(i).position.y > alto / 2)
                    {
                        SpawnBola();
                        B = true;
                    }
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Ended)
                {
                }
            }
        }
        else
        {
            return;
        }

#endif
    }
    void SpawnBola()    
    {
        Instantiate(bola, spawnPos, Quaternion.identity);
    }
}