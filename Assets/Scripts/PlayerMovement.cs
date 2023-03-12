using Oculus.Interaction;
using Oculus.Interaction.OVR.Input;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;
    private CharacterController controller;
    private bool walk;
    [SerializeField]
    private Transform _camera;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
       


    }
    public void NoWalk()
    {
        walk = false;
        Move();
    }
    public void Walk()
    {
        walk = true;
        Move();
    }
    public void Move()
    {
        if (walk)
        {
            Vector3 forward = _camera.forward;
            forward.y = 0;
            forward = forward.normalized;

            // Mover al jugador
            controller.Move(forward * speed * Time.deltaTime);
        }
        else
        {
            Vector3 forward = _camera.forward;
            forward.y = 0;
            forward = forward.normalized;

            // Mover al jugador
            controller.Move(forward * 0 * Time.deltaTime);
            

        }


    }

}

