using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjusteResol : MonoBehaviour
{
    public bool maintainWidth = true;
    float defaultWidth;

    void Start()
    {
        defaultWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }
    void Update()
    {
        if (maintainWidth)
        {
            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;
        }
        else
        {
        }
    }
    }
