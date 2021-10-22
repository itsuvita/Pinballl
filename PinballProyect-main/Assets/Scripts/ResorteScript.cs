using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResorteScript : MonoBehaviour
{
    float poder;
    float minPoder = 0f;
    public float maxPoder=15f;
    public Slider poderSlider;
    List<Rigidbody> Lista;
    bool BolaReady;
    bool fuerza = false;
    public GameObject force;

    void Start()
    {
        poderSlider.minValue = minPoder;
        poderSlider.maxValue = maxPoder;
        Lista = new List<Rigidbody>();
    }

    void Update()
    {
        poderSlider.value = poder;
        if(BolaReady)
        {
            poderSlider.gameObject.SetActive(true);
        }
        else
        {
            poderSlider.gameObject.SetActive(false);
        }

        if(Lista.Count>0)
        {
            BolaReady = true;
            if(Input.GetKey(KeyCode.Space))
            {
                if(poder<=maxPoder)
                {
                    poder+=4f*Time.deltaTime;
                }
            }
            if(Input.GetKeyUp(KeyCode.Space))
            {
                foreach(Rigidbody r in Lista)
                {
                    r.AddForce(poder*Vector3.forward);
                }
            }
            if (fuerza == true)
            {
                if (poder <= maxPoder)
                {
                    poder += 4f * Time.deltaTime;
                }
            }
            if (fuerza == false)
            {
                foreach (Rigidbody r in Lista)
                {
                    r.AddForce(poder * Vector3.forward);
                }

            }

        }
        else
        {
            BolaReady = false;
            poder = 0f;
        }
#if UNITY_ANDROID
        float ancho = Screen.width;
        float alto = Screen.height;
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if (Input.GetTouch(i).position.x < ancho / 2 && Input.GetTouch(i).position.y > alto / 2)
                {
                    if (poder <= maxPoder)
                    {
                        poder += 4f * Time.deltaTime;
                    }

                }
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Ended)
            {
                foreach (Rigidbody r in Lista)
                {
                    r.AddForce(poder * Vector3.forward);
                }

            }
        }

#endif
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bolas"))
        {
            Lista.Add(other.gameObject.GetComponent<Rigidbody>());
            force.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Bolas"))
        {
            Lista.Remove(other.gameObject.GetComponent<Rigidbody>());
            poder = 0f;
            force.SetActive(false);
        }
    }public void BotonFuerza()
    {
        fuerza = !fuerza;
    }
}