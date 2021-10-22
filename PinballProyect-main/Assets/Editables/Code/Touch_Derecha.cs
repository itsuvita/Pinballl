using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Derecha : MonoBehaviour
{
    public bool activado;
    public PaletaScript A;
    // Start is called before the first frame update
    private void Start()
    {
        activado = A.Active;
    }
    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID
                float ancho = Screen.width;
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if (Input.GetTouch(i).position.x > ancho / 2)
                {
                    A.Active = true;
                }
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Ended)
            {
                A.Active = false;
            }
        }
#endif
#if UNITY_STANDALONE
        if (Input.GetMouseButton(0))
        {
            float ancho = Screen.width;
            if (Input.mousePosition.x > ancho / 2)
            {
                A.Active = true;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            A.Active = false;
        }

#endif
    }

}
