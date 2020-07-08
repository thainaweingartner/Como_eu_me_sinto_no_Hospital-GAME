using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confirmar_Nome : MonoBehaviour
{
    public static string nomePlayer;
    public GameObject savename;
    private void Start()
    {
        savename.SetActive(false);
    }
    public void botao_nome()
    {
        savename.SetActive(true);
        nomePlayer = GetComponent<InputField>().text;
        Debug.Log("Nome: " + nomePlayer);
        GetComponent<InputField>().text = "";
        savename.GetComponent<Text>().text = "Nome Salvo: " + nomePlayer;
    }
}
