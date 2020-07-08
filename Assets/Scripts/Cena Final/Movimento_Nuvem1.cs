using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Nuvem1 : MonoBehaviour
{
    int a;
    private void Start()
    {
        transform.position = new Vector3(1.32f, 3.88f, 0);
    }
    // Update is called once per frame
    void Update()
    {

        if (transform.position == new Vector3(1.32f, 3.88f, 0))
        {
            a = 1;

        }
        if (transform.position == new Vector3(4.57f, 3.88f,  0))
        {
            a = 0;
        }

        if (a == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(4.57f, 3.88f, 0), Time.deltaTime);
            
        }
        if (a == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(1.32f, 3.88f, 0), Time.deltaTime);
            
        }

    }
}
