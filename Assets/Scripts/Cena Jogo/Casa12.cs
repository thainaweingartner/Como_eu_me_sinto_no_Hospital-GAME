using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Casa12 : MonoBehaviour
{
    public GameObject player;
    public GameObject posicao;
    public GameObject pergunta;
    public GameObject resposta;
    public GameObject botao;
    public static string perguntaExtra;
    public static string respostaExtra;
    public int check = 0;




    private void Start()
    {
        resposta.transform.position = new Vector3(0, -3.4f, -6);
        botao.transform.position = new Vector3(0, -4.3f, -6);
        botao.SetActive(false);
        pergunta.SetActive(false);
        resposta.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (player.transform.position == posicao.transform.position)
        {
            check = 1;
            pergunta.SetActive(true);
            resposta.SetActive(true);
            botao.SetActive(true);
        }
        if (check == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, -5), 15 * Time.deltaTime);
        }
        if (transform.position == new Vector3(0, 0, -5))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 180, 0), 5 * Time.deltaTime);
            player.SetActive(false);
            pergunta.transform.position = new Vector3(0, -0.7f, -6);
        }

    }

    public void botaoConfirma()
    {
        respostaExtra = resposta.GetComponent<InputField>().text;
        perguntaExtra = pergunta.GetComponent<InputField>().text;
        pergunta.SetActive(false);
        resposta.SetActive(false);
        botao.SetActive(false);
        gameObject.SetActive(false);
        player.SetActive(true);

        Debug.Log("Pergunta Extra: " + perguntaExtra + "Resposta Extra: " + respostaExtra);
    }
}