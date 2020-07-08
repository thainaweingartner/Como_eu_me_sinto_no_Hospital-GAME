using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Nuvem : MonoBehaviour
{
    int a;
    private void Start()
    {
        transform.position = new Vector3(5.5f, 4,-5);
    }
    // Update is called once per frame
    void Update()
    {

        if (transform.position == new Vector3(5.5f, 4,-5))
        {
            a = 1;

        }
        if (transform.position == new Vector3(1.5f, 4,-5))
        {
            a = 0;
        }

        if (a == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(1.5f, 4, -5), Time.deltaTime);
            
        }
        if (a == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(5.5f, 4, -5), Time.deltaTime);
            
        }

    }
}
