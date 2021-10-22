    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toucheado : MonoBehaviour
{
    public GameObject muro;
    bool reset = false;
    public Crecer_Barra A;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Update()
    {
        if (reset == true)
        {
            muro.transform.localScale = new Vector3(0, 0, 0);
            A.A = 0;
            muro.SetActive(false);
            reset = false;
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            muro.SetActive(true);
        }
    }
    public void Pase (bool other)
    {
        reset = other;
    }
}
