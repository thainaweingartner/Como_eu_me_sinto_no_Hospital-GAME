using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Carro : MonoBehaviour
{
    int a;
    private void Start()
    {
        transform.position = new Vector3(1, -3.8f);
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position == new Vector3(1, -3.8f))
        {
            a = 1;
      
        }
        if (transform.position == new Vector3(5.2f, -3.8f))
        {
            a = 0;
        }

        if (a == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(5.2f, -3.8f), Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (a == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(1, -3.8f), Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true;
        }

    }
}
