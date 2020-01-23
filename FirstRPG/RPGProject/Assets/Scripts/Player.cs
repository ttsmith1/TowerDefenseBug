using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;
    Vector3 lastPosition = new Vector3(0, 0, 0);
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
        if (lastPosition != gameObject.transform.position)
        {
            anim.SetBool("Walking", true);
        } else {
            anim.SetBool("Walking", false);
        }
        lastPosition = gameObject.transform.position;
    }
}
