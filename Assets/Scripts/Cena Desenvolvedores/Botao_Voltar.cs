using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botao_Voltar : MonoBehaviour
{
    public void botao_voltar()
    {
        SceneManager.LoadScene(0);
    }
}
