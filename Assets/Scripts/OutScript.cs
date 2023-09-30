using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            GameManager.instance.resetBall();
            TextManager.textManagerIntance.resetScore();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            GameManager.instance.resetBall();
        }
    }
}
