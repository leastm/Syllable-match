using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerMovement2 : MonoBehaviour
{

    //deplacement p2
    public float vitesseDeplacement2 = 1f;

    private GameObject p1;

    // Update is called once per frame
    void Update()
    {

        // deplacement 1
        transform.Translate(Deplacement() * vitesseDeplacement2 * Time.deltaTime);
       //
       

        Vector3 Deplacement()
        {
            Vector3 direction = Vector3.zero;

            //gauche droite
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                direction += Vector3.left;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                direction += Vector3.right;
            }

            //haut bas
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direction += Vector3.up;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                direction += Vector3.down;
            }

            return direction;
        }

        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("mots"))
        {
            
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log($"if statement: " + collider.CompareTag("mots"));
               Destroy(collider.gameObject);
               collider.enabled = false;
            }

        }

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Collided with: " + collisionInfo.gameObject.name);
    }
}
