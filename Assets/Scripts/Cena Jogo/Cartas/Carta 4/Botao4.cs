using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botao4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject posicao;
    public GameObject input;
    public GameObject carta;
    public static string resposta4 = "Não Respondeu";
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
        resposta4 = input.GetComponent<InputField>().text;
        Debug.Log("Resposta 4: " + resposta4);
        sair = 1;
    }
}
