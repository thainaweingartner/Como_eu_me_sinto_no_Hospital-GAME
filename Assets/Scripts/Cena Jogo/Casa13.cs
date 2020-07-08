using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Casa13 : MonoBehaviour
{
    public GameObject posicaoFim;
    public GameObject posicao13;
    public GameObject historia;
    public GameObject imaginacao;
    public GameObject respiracao;
    public GameObject botaofim;
    int check=0;
    int n = 0;
    void Start()
    {
        historia.SetActive(false);
        imaginacao.SetActive(false);
        respiracao.SetActive(false);
        botaofim.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == posicao13.transform.position && n==0)
        {
            historia.SetActive(true);
            imaginacao.SetActive(true);
            respiracao.SetActive(true);
            botaofim.SetActive(true);
            gameObject.SetActive(false);
        }

        if (check == 1)
        {
            historia.SetActive(false);
            imaginacao.SetActive(false);
            respiracao.SetActive(false);
            botaofim.SetActive(false);
            transform.position = Vector3.MoveTowards(transform.position,posicaoFim.transform.position,4*Time.deltaTime);
        }
        if(transform.position == posicaoFim.transform.position)
        {
            SceneManager.LoadScene(7);
        }


    }

    public void botaoHistoria()
    {
        SceneManager.LoadScene(4);
    }

    public void botaoImaginacao()
    {
        SceneManager.LoadScene(5);
    }

    public void botaoRespiracao()
    {
        SceneManager.LoadScene(6);
    }
    public void botaoFim()
    {
        check = 1;
        gameObject.SetActive(true);
        n = 1;
    }

}
