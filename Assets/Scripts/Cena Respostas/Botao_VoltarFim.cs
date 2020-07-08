using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botao_VoltarFim : MonoBehaviour
{
    
    public void voltar()
    {
        SceneManager.LoadScene(7);
    }
}
