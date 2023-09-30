using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularDriveFunction : MonoBehaviour
{
    public GameObject Wall1;
    public GameObject Wall1_1;
    public GameObject Wall1_2;
    public GameObject Wall2;
    public GameObject Wall2_1;
    public GameObject Wall2_2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveWallsIn()
    {
        Vector3 right = new Vector3(-0.2f, 0, 0);

        Vector3 left = new Vector3(0.2f, 0, 0);
        Wall1.transform.position = Wall1.transform.position + right;
        Wall1_1.transform.position = Wall1_1.transform.position + right;
        Wall1_2.transform.position = Wall1_2.transform.position + right;
        Wall2.transform.position = Wall2.transform.position + left;
        Wall2_1.transform.position = Wall2_1.transform.position + left;
        Wall2_2.transform.position = Wall2_2.transform.position + left;
    }
    public void moveWallsOut()
    {
        Vector3 right = new Vector3(0.2f, 0, 0);
        Vector3 left = new Vector3(-0.2f, 0, 0);
        Wall1.transform.position = Wall1.transform.position + right;
        Wall1_1.transform.position = Wall1_1.transform.position + right;
        Wall1_2.transform.position = Wall1_2.transform.position + right;
        Wall2.transform.position = Wall2.transform.position + left;
        Wall2_1.transform.position = Wall2_1.transform.position + left;
        Wall2_2.transform.position = Wall2_2.transform.position + left;
    }
}
