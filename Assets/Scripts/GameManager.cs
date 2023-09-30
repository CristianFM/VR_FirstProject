using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject ball;
    public GameObject ballSpawn;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetBall()
    {
        ball.transform.position = ballSpawn.transform.position;
        ball.GetComponent<Rigidbody>().velocity = new Vector3 (0,0,0);
    }
}
