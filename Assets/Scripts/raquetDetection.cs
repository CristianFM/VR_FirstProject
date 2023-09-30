using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raquetDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Sphere_1")
        {
            Debug.Log(gameObject.GetComponent<Rigidbody>().velocity);
            Debug.Log("ball collisionEnter");
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Sphere_1")
        {
            Debug.Log("ball collisionStay");
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Sphere_1")
        {
            Debug.Log("ball collisionExiut");
        }

    }
}
