using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenClean : MonoBehaviour
{
    public GameObject señal;
    public GameObject boton;
    public GameObject panel;
    public Master A;
    int vidas;
    public int AdLimit;
    private void Start()
    {
        vidas = 3;
        AdLimit = 1;
    }
    private void Update()
    {
        
        if (vidas == 0)
        {
            if (AdLimit == 1)
            {
                panel.SetActive(true);
            }
            if (AdLimit == 0)
            {
                SceneManager.LoadScene("Youlose");
            }
        } else 
        { 
            return; 
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            Destroy(other.gameObject);
            vidas -= 1;
            señal.SendMessage("Pase", true);
            boton.SetActive(true);
            A.B = false;
        }
    }
    public void Receptor(int mensaje)
    {
        mensaje -= AdLimit;
    }
}