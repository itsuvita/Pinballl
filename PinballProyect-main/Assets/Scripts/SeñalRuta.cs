using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeñalRuta : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sgtSe,org;
    public bool sign;
    void Start()
    {
        sign = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (sign == true)
        {
            sgtSe.SetActive(true);
            org.SendMessage("Pase", 1);
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Model"))
        {
            sign = true;
        }
    }
}
