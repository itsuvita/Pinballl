using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class MovimientoModelo : MonoBehaviour
{
    Vector3 orig;
    int count;
    GameObject mensajero;
    public float velocidad = 3f;
    public PathCreator ruta;
    float distancia;
    // Start is called before the first frame update
    void Start()
    {
        orig = gameObject.transform.position;
        count = 3;
    }

    // Update is called once per frame
    void Update()
    {
        distancia += velocidad * Time.deltaTime;
        transform.position = ruta.path.GetPointAtDistance(distancia);
        transform.rotation = ruta.path.GetRotationAtDistance(distancia);
        if (count == 0)
        {
            mensajero.SendMessage("Maid", false);
            gameObject.SetActive(false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bolas"))
        {
            count -= 1;
        }
    }
}
