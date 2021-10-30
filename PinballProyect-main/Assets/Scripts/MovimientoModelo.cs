using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoModelo : MonoBehaviour
{
    public Transform origen;
    Vector3 orig;
    Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = origen.transform.position;
        orig = gameObject.transform.position;
        obj = GameObject.FindGameObjectWithTag("pos").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        orig = Vector3.MoveTowards(orig, obj.position, 2f * Time.deltaTime);
    }
}
