using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ballPhysic : MonoBehaviour
{
    private Vector3 direction;
    private RacketController racketController;
    private Rigidbody rb;
    public float dist;
    public GameObject raquet;
    public Vector3 raquetVel;
    public Vector3 RaquetNormal;
    public SteamVR_TrackedObject trackedObj;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        test();
        getRaquetNormalVector();
    }

    void test()
    {
        float dist = Vector3.Distance(raquet.transform.position, transform.position);
        
        if(dist <= 1f)

        if (dist <= 0.5f)
        {
            getRaquetNormalVector();
;        }
    }

    public void getRaquetNormalVector()
    {
        //Vector3 vel = device.velocity;
        raquetVel = raquet.GetComponent<Rigidbody>().velocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "RaquetController")
        {
            direction = Vector3.Reflect(racketController.LastFrameVelocity, collision.contacts[0].normal);
            rb.velocity = direction;
        }
    }
}
