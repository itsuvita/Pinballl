using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenClean : MonoBehaviour
{
    public GameObject se�al;
    public GameObject boton;
    public Master A;
    int vidas;
    private void Update()
    {
        if (vidas == 3)
        {
            SceneManager.LoadScene("Youlose");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            Destroy(other.gameObject);
            vidas += 1;
            se�al.SendMessage("Pase", true);
            boton.SetActive(true);
            A.B = false;
        }
    }
}