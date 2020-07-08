using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta6 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject posicao;

    void Start()
    {
        transform.position = new Vector3(0, -15, -5);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position == posicao.transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, -5), 15 * Time.deltaTime);
        }
        if (transform.position == new Vector3(0, 0, -5))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 180, 0), 5 * Time.deltaTime);

            player.SetActive(false);
        }
    }
}
