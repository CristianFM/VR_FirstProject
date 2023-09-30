using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 movementInput;
    public float speed = 1;
    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();  
    }
    // Update is called once per frame
    void Update()
    {
        if(movementInput.axis.magnitude > 0.1f)
        {
            Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(movementInput.axis.x, 0, movementInput.axis.y));
            characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0, 9.18f, 0) * Time.deltaTime);
        }
    }
}
