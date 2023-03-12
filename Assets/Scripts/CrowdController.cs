using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrowdController : MonoBehaviour
{
    //Array con las posiciones de todos los hitos
    GameObject[] goalPositions;
    NavMeshAgent agent;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        goalPositions = GameObject.FindGameObjectsWithTag("goal");
        agent = this.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<Animator>();

        //Modificar parametros de Offset
        anim.SetFloat("animOffset", Random.Range(0f, 1f));

        float speedMultiplier = Random.Range(0.5f, 2f);
        anim.SetFloat("speedMult", speedMultiplier);
        agent.speed = agent.speed * speedMultiplier;

        //Asignamos un destino y cambiamos la animación
        agent.SetDestination(goalPositions[Random.Range(0, goalPositions.Length)].transform.position);
        anim.SetTrigger("isWalking");


    }

    // Update is called once per frame
    void Update()
    {
        //Si estamos suficientemente cerca del objetivo, cambiamos el objetivo
        if (agent.remainingDistance < 1)
        {
            agent.SetDestination(goalPositions[Random.Range(0, goalPositions.Length)].transform.position);
        }
    }
}
