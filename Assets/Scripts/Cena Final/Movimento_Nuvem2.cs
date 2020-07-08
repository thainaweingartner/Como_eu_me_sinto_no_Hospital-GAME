using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Nuvem2 : MonoBehaviour
{
    int a;
    private void Start()
    {
        transform.position = new Vector3(2.35f, 3.64f);
    }
    // Update is called once per frame
    void Update()
    {

        if (transform.position == new Vector3(2.35f, 3.64f))
        {
            a = 1;

        }
        if (transform.position == new Vector3(5.65f, 3.64f))
        {
            a = 0;
        }

        if (a == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(5.65f, 3.64f), Time.deltaTime);
            
        }
        if (a == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(2.35f, 3.64f), Time.deltaTime);
            
        }

    }
}
