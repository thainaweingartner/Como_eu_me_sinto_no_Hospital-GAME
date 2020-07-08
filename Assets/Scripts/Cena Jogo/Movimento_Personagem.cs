using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Personagem : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject[] posicoes;
    public GameObject botaoAvancar;
    public GameObject botaoGo12;
    int i=0;
    int n = 0;
    public bool check=false;

    void Start()
    {
        transform.position = posicoes[0].transform.position;
    }

    void Update()
    {
        if(check == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicoes[i+1].transform.position, 4*Time.deltaTime);
        }

        if (transform.position == posicoes[i + 1].transform.position ) 
        {
            i++;
            check = false;
        }
        if (i >=14)
        {
            transform.position = posicoes[14].transform.position;
            i = -1;
        }

        if (n == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicoes[12].transform.position, 6 * Time.deltaTime);
        }
        if(transform.position == posicoes[12].transform.position)
        {
            n = 0;
            botaoGo12.SetActive(false);
        }
        if(transform.position == posicoes[13].transform.position)
        {
            botaoAvancar.SetActive(false);
            
        }
   
    }
    public void avancar()
    {
        check = true;
    }

    public void go12()
    {
        i = 12;
        n = 1;
        check = false;

    }
}
