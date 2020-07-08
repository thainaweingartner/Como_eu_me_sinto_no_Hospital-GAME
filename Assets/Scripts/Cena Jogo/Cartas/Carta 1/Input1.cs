using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input1 : MonoBehaviour
{
    public GameObject player;
    public GameObject posicao;
    int check;
    private void Update()
    {
        if (player.transform.position == posicao.transform.position)
        {
            check = 1;
        }

        if (check == 1)
        {
           transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, -3.4f, -6), 15 * Time.deltaTime);
        }

        if (transform.position == new Vector3(0, -3.3f, -6))
        {
            check = 0;
        }

    }
    

}
