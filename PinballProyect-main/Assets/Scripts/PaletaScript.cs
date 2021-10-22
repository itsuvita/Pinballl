using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletaScript : MonoBehaviour
{
    public float restPos = 0f;
    public float pressedPos = 45f;
    public float hitStr = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public string inputName;
    public bool Active;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStr;
        spring.damper = flipperDamper;
        if(Input.GetAxis(inputName)==1 || Active==true)
        {
            spring.targetPosition = pressedPos;
        }
        else
        {
            spring.targetPosition = restPos;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}