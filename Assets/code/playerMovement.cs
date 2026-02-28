using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerMovement : MonoBehaviour
{
    //deplacement p1
    public float vitesseDeplacement1 = 1f;

    //deplacement p2
    public float vitesseDeplacement2 = 1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }



    // Update is called once per frame
    void Update()
    {


        // deplacement 1
        transform.Translate(Deplacement() * vitesseDeplacement1 * Time.deltaTime);
        transform.Translate(Deplacement() * vitesseDeplacement2 * Time.deltaTime);


    }

    Vector3 Deplacement()
    {
        Vector3 direction = Vector3.zero;

        //gauche droite
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        //haut bas
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.down;
        }

        return direction;
    }
}
