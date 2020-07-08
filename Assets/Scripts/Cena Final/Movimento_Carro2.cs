using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Carro2 : MonoBehaviour
{
    int a;
    private void Start()
    {
        transform.position = new Vector3(-5.18f, -3.34f);
    }
    // Update is called once per frame
    void Update()
    {
        
        if (transform.position == new Vector3(-5.18f, -3.34f))
        {
            a = 1;
      
        }
        if (transform.position == new Vector3(5.29f, -3.34f))
        {
            a = 0;
        }

        if (a == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(5.29f, -3.34f), Time.deltaTime*2);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (a == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5.18f, -3.34f), Time.deltaTime*2);
            GetComponent<SpriteRenderer>().flipX = true;
        }

    }
}
