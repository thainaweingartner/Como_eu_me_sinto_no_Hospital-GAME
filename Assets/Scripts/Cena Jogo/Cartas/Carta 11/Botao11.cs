using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botao11 : MonoBehaviour
{
    public GameObject player;
    public GameObject posicao;
    public GameObject input;
    public GameObject carta;
    public static string resposta11 = "Não Respondeu";
    int sair = 0;

    int check;
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position == posicao.transform.position)
        {
            check = 1;
        }

        if (check == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, -4.3f, -6), 15 * Time.deltaTime);
        }

        if (transform.position == new Vector3(0, -4.3f, -6))
        {
            check = 0;
        }

        if (sair == 1)
        {
            check = 0;
            input.SetActive(false);
            carta.SetActive(false);
            posicao.SetActive(false);
            player.SetActive(true);
            sair = 0;
            gameObject.SetActive(false);
        }

    }

    public void botaoR1()
    {
        resposta11 = input.GetComponent<InputField>().text;
        Debug.Log("Resposta 11: " + resposta11);
        sair = 1;
    }
}
