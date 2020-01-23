using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
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
    }
    //Variables
    //public float movementSpeed;
    //public GameObject playerMovePoint;
    //private Transform pmr;
    //private bool moving;
    //private bool pmrSpawned;
    //private GameObject triggeringPMR;


    //Functions
    //private void Update()
    //{
    //    //Player movement
    //    Plane playerPlane = new Plane(Vector3.up, transform.position);
    //    Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
    //    float hitDstance = 0.0f;

    //    if(playerPlane.Raycast(ray, out hitDstance)) 
    //    {
    //        Vector3 mousePosition = ray.GetPoint(hitDstance);
    //        if (Input.GetMouseButtonDown(0))
    //        {
    //            moving = true;
    //            if (pmrSpawned)
    //            {
    //                pmr = null;
    //                pmr = Instantiate(playerMovePoint.transform, mousePosition, Quaternion.identity);
    //            } else {
    //                pmr = Instantiate(playerMovePoint.transform, mousePosition, Quaternion.identity);
    //            }
    //        }
    //    }
    //    if (pmr)
    //        pmrSpawned = true;
    //    else
    //        pmrSpawned = false;
    //    if (moving)
    //        Move();
    //}

    //public void Move()
    //{
    //    transform.position = Vector3.MoveTowards(transform.position, pmr.transform.position, movementSpeed);
    //    this.transform.LookAt(pmr.transform);
    //}

    //void ObTriggerEnter(Collider other)
    //{
    //    if(other.tag == "PMR")
    //    {
    //        triggeringPMR = other.gameObject;
    //        triggeringPMR.GetComponent<PMR>().DestroyPMR();
    //    }
    //}
}
