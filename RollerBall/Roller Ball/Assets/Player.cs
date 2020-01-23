using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Player variables
    public float movementSpeed;

    public void Start()
    {
        
    }

    public void Update()
    {
        //Player movement
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
    }

}
