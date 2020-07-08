using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GerarTXT : MonoBehaviour
{
    string nome = Confirmar_Nome.nomePlayer;
    string[] respostas = { Botao1.resposta1,
                    Botao2.resposta2,
                    Botao3.resposta3,
                    Botao4.resposta4,
                    Botao5.resposta5,
                    botao6.resposta6,
                    Botao7.resposta7,
                    Botao8.resposta8,
                    Botao9.resposta9,
                    Botao10.resposta10,
                    Botao11.resposta11};
    string perguntaextra = Casa12.perguntaExtra;
    string respostaextra = Casa12.respostaExtra;

    public void criarTXT()
    {
        int i;
        //caminho para criar o txt
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string caminho = Path.Combine(desktop, nome + ".txt");

        //criar um txt se não existir
        if (!File.Exists(caminho))
        {
            File.WriteAllText(caminho, "COMO EU ME SINTO NO HOSPITAL:\n\n");
        }

        //adicionar as respostas ao txt
        File.AppendAllText(caminho, nome + " " + System.DateTime.Now + "\n");
        for (i = 0; i < 11; i++)
        {
            File.AppendAllText(caminho, "Resposta " + (i + 1) + ": " + respostas[i] + "\n");
        }
        File.AppendAllText(caminho, "\n");
        File.AppendAllText(caminho, "\n" + perguntaextra + ": " + respostaextra + "\n");
        File.AppendAllText(caminho, "---------------------------------------------------------------------\n");

    }

 
}
