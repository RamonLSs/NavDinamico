using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    private int sentido;
    // Start is called before the first frame update
    void Start()
    {
        sentido = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -9.0f && sentido == -1)
        {
            sentido = 1;
        }

        if(transform.position.z > 9.0f && sentido == 1)
        {
            sentido = -1;
        }

        transform.position = transform.position + new Vector3(0,0,sentido)*3*Time.deltaTime;
    }
}
